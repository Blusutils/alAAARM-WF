using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace alAAARM {
    internal class Alarm {
        public string AlarmName { get; set; }
        public DateTime WhenAlarmStart { get; set; }
        public TreeNode AssociatedNodeInForm { get; set; }
        public bool Repeat { get; set; } = false;
        public AudioFileReader AlarmSound { get; set; } = new AudioFileReader(@"D:\example.mp3");
        public bool Queued { get; private set; } = false;
        Thread alarmThread;
        WaveOutEvent outputDevice;

        public Alarm(string alarmName, DateTime whenAlarmStart, TreeNode associatedNodeInForm, bool repeat = false, AudioFileReader alarmSound = null) {
            AlarmName = alarmName;
            WhenAlarmStart = whenAlarmStart;
            AssociatedNodeInForm = associatedNodeInForm;
            Repeat = repeat;
            AlarmSound = alarmSound ?? AlarmSound;
        }
        public void QueueAlarm() {
            Queued = true;
            alarmThread = new Thread(() => {
                if (AlarmQueueEvent != null) AlarmQueueEvent(this);
                do { Thread.Sleep(1); } while (WhenAlarmStart - DateTime.Now > TimeSpan.Zero);
                if (outputDevice == null) {
                    outputDevice = new WaveOutEvent();
                    if (AlarmSound == null) AlarmSound = new AudioFileReader(Config.alarmSoundsPathes[Config.Instance.selectedSound]);
                    var wavstr = new LoopingWaveStream(AlarmSound);
                    wavstr.EnableLooping = Repeat;
                    outputDevice.Init(wavstr);
                    outputDevice.PlaybackStopped += (object _s, StoppedEventArgs _a) => {
                        if (!(Repeat && Queued)) {
                            outputDevice.Stop();
                            outputDevice.Dispose();
                            outputDevice = null;
                            wavstr.Dispose();
                            wavstr = null;
                        }
                    };
                }
                outputDevice.Volume = Config.Instance.soundVolume / 100f;
                outputDevice.Play();
                if (AlarmStartEvent != null) AlarmStartEvent(this);
            });
            alarmThread.Start();
        }
        public void StopAlarm() {
            Queued = false;
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing) {
                outputDevice.Stop();
            }
            if (AssociatedNodeInForm != null) {
                AssociatedNodeInForm.Remove();
            }
            if (alarmThread != null && alarmThread.IsAlive) {
                alarmThread.Abort();
                alarmThread = null;
            }
            if (AlarmEndEvent != null) AlarmEndEvent(this);
        }

        public delegate void AlarmEventDelegate(Alarm targetAlarm);
        public static event AlarmEventDelegate AlarmQueueEvent;
        public static event AlarmEventDelegate AlarmStartEvent;
        public static event AlarmEventDelegate AlarmEndEvent;

        private static List<Alarm> Alarms { get; set; } = new List<Alarm>();
        public static void AddAlarm(Alarm alarm, bool queue = false) {
            Alarms.Add(alarm);
            if (queue) alarm.QueueAlarm();
        }
        public static void RemoveAlarm(Alarm alarm) {
            Alarms.Remove(alarm);
            if (alarm.Queued) alarm.StopAlarm();
        }
        public static List<Alarm> GetAlarms() {
            return Alarms;
        }

        public static Alarm FindAlarm(int id) {
            try {
                return Alarms[id];
            } catch (IndexOutOfRangeException) {
                return null;
            }
        }
        public static Alarm FindAlarm(string name) {
            foreach (var al in Alarms) {
                if (al.AlarmName == name) return al;
            }
            return null;
        }
        public static Alarm FindAlarm(TreeNode associatedNode) {
            foreach (var al in Alarms) {
                if (al.AssociatedNodeInForm.Equals(associatedNode)) return al;
            }
            return null;
        }
    }
}
