using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace alAAARM {
    internal class Alarm {
        /// <summary>
        /// Alarm name
        /// </summary>
        public string AlarmName { get; set; }
        /// <summary>
        /// Time, when this alarm will start
        /// </summary>
        public DateTime WhenAlarmStart { get; set; }
        /// <summary>
        /// Associated <see cref="TreeNode"/> in <see cref="Form"/>
        /// </summary>
        public TreeNode AssociatedNodeInForm { get; set; }
        /// <summary>
        /// Is alarm sound repeating
        /// </summary>
        public bool Repeat { get; set; } = false;
        /// <summary>
        /// Sound of this alarm
        /// </summary>
        public AudioFileReader AlarmSound { get; set; } = new AudioFileReader(@"D:\example.mp3");
        /// <summary>
        /// Is this alarm queued?
        /// </summary>
        public bool Queued { get; private set; } = false;
        /// <summary>
        /// Alarm sound volume
        /// </summary>
        public float Volume { get; set; }
        /// <summary>
        /// Need to maximize alAAARM from tray when this alarm triggers?
        /// </summary>
        public bool Untray { get; set; } = true;

        /// <summary>
        /// Thread, where happends all magic ✨
        /// </summary>
        Thread alarmThread;
        /// <summary>
        /// NAudio Wave output device
        /// </summary>
        WaveOutEvent outputDevice;

        /// <summary>
        /// Constructor of alarm
        /// </summary>
        public Alarm() {
        }
        /// <summary>
        /// Queue alarm startup
        /// </summary>
        public void QueueAlarm() {
            Queued = true;
            alarmThread = new Thread(() => {
                // call queue event
                if (AlarmQueueEvent != null) AlarmQueueEvent(this);
                // sleep until WhenAlarmStart minus current time will not be equal zero timespan
                do { Thread.Sleep(1); } while (WhenAlarmStart - DateTime.Now > TimeSpan.Zero);
                
                // some NAudio magic
                outputDevice = new WaveOutEvent();
                if (AlarmSound == null) AlarmSound = new AudioFileReader(Config.alarmSoundsPathes[Config.Instance.selectedSound]);
                // wow, looping Wave player!
                var wavstr = new LoopingWaveStream(AlarmSound);
                wavstr.EnableLooping = Repeat;
                outputDevice.Init(wavstr);
                outputDevice.PlaybackStopped += (object _s, StoppedEventArgs _a) => {
                    // if repeat is disabled or alarm not queued, we'll destroy everything
                    if (!(Repeat && Queued)) {
                        outputDevice.Stop();
                        outputDevice.Dispose();
                        outputDevice = null;
                        wavstr.Dispose();
                        wavstr = null;
                    }
                };
                // *annoying alarm clock sounds*
                outputDevice.Volume = Volume/100f;
                outputDevice.Play();
                // call start event
                if (AlarmStartEvent != null) AlarmStartEvent(this);
            });

            alarmThread.Start();
        }
        /// <summary>
        /// Stop alarm work and unqueue it
        /// </summary>
        public void StopAlarm() {
            // stop thread
            if (alarmThread != null && alarmThread.IsAlive) {
                alarmThread.Abort();
                alarmThread = null;
            }
            // unqueue
            Queued = false;
            // stop Wave player
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing) {
                outputDevice.Stop();
            }
            // remove TreeNode
            if (AssociatedNodeInForm != null) {
                AssociatedNodeInForm.Remove();
            }
            // call end event
            if (AlarmEndEvent != null) AlarmEndEvent(this);
        }

        /// <summary>
        /// Delegate for all events with <see cref="Alarm"/>
        /// </summary>
        /// <param name="targetAlarm">Target instance of <see cref="Alarm"/> with which event occurs</param>
        public delegate void AlarmEventDelegate(Alarm targetAlarm);
        /// <summary>
        /// Event what calls when alarm queues
        /// </summary>
        public static event AlarmEventDelegate AlarmQueueEvent;
        /// <summary>
        /// Event what calls when alarm start it work
        /// </summary>
        public static event AlarmEventDelegate AlarmStartEvent;
        /// <summary>
        /// Event what calls when alarm end it work
        /// </summary>
        public static event AlarmEventDelegate AlarmEndEvent;

        /// <summary>
        /// List of all alarms
        /// </summary>
        private static List<Alarm> Alarms { get; set; } = new List<Alarm>();

        /// <summary>
        /// Add an alarm
        /// </summary>
        /// <param name="alarm">Alarm to add</param>
        /// <param name="queue">Need to queue alarm after adding?</param>
        public static void AddAlarm(Alarm alarm, bool queue = false) {
            Alarms.Add(alarm);
            if (queue) alarm.QueueAlarm();
        }
        /// <summary>
        /// Remove alarm and stop it
        /// </summary>
        /// <param name="alarm">Target alarm</param>
        public static void RemoveAlarm(Alarm alarm) {
            Alarms.Remove(alarm);
            if (alarm.Queued) alarm.StopAlarm();
        }
        /// <summary>
        /// Get list of all alarms
        /// </summary>
        /// <returns><see cref="List{Alarm}"/><see cref="Alarm"/> List of alarms</returns>
        public static List<Alarm> GetAlarms() {
            return Alarms;
        }

        /// <summary>
        /// Find alarm by ID (index)
        /// </summary>
        /// <param name="id">Alarm index</param>
        /// <returns>Found <see cref="Alarm"/> or null</returns>
        public static Alarm FindAlarm(int id) {
            try {
                return Alarms[id];
            } catch (IndexOutOfRangeException) {
                return null;
            }
        }
        /// <summary>
        /// Find alarm by name
        /// </summary>
        /// <param name="name">Alarm name</param>
        /// <returns>Found <see cref="Alarm"/> or null</returns>
        public static Alarm FindAlarm(string name) {
            foreach (var al in Alarms) {
                if (al.AlarmName == name) return al;
            }
            return null;
        }
        /// <summary>
        /// Find alarm by <see cref="TreeNode"/> associated with it
        /// </summary>
        /// <param name="associatedNode">Node, associated with <see cref="Alarm"/></param>
        /// <returns>Found <see cref="Alarm"/> or null</returns>
        public static Alarm FindAlarm(TreeNode associatedNode) {
            foreach (var al in Alarms) {
                if (al.AssociatedNodeInForm.Equals(associatedNode)) return al;
            }
            return null;
        }
    }
}
