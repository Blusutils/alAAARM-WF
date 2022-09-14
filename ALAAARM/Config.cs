using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace alAAARM {
    internal class Config {

        private byte _soundVolume = 0;
        public byte soundVolume { get => _soundVolume; set { _soundVolume = value; Write(); } }

        private string _selectedSound = "Beep Beep Beep";
        public string selectedSound { get => _selectedSound; set { _selectedSound = value; Write(); } }

        private string _customSoundPath = "";
        public string customSoundPath { get => _customSoundPath; set { _customSoundPath = value; Write(); } }

        private bool _useRelativeTime = true;
        public bool useRelativeTime { get => _useRelativeTime; set { _useRelativeTime = value; Write(); } }

        private bool _repeatSound = true;
        public bool repeatSound { get => _repeatSound; set { _repeatSound = value; Write(); } }

        private bool _untray = true;
        public bool untray { get => _untray; set { _untray = value; Write(); } }

        private string _language = "";
        public string language { get => _language; set { _language = value; Write(); } }


        [JsonIgnore]
        public static Dictionary<string, string> alarmSoundsPathes;
        [JsonIgnore]
        public static Config Instance;

        [JsonConstructor]
        Config() { }

        private static void Write() {
            File.WriteAllText(Path.Combine(Program.appPath, "config.json"), JsonConvert.SerializeObject(Instance, Formatting.Indented));
        }
        public static void Load() {
            if (File.Exists(Path.Combine(Program.appPath, "config.json")))
                Instance = JsonConvert.DeserializeObject<Config>(File.ReadAllText(Path.Combine(Program.appPath, "config.json")));
            if (Instance == null) {
                Instance = new Config();
                Write();
            }
            
            alarmSoundsPathes = new Dictionary<string, string>() {
                { "Beep Beep Beep", Path.Combine(Program.appPath, "alarms", "beepbeepbeep.mp3") },
                { "Beep Beep Beep Alternate", Path.Combine(Program.appPath, "alarms", "beepbeepbeep2.mp3") },
                { "Alarm clock", Path.Combine(Program.appPath, "alarms", "alarmclock.mp3") },
                { "Sinusoid", Path.Combine(Program.appPath, "alarms", "sinusoid.mp3") },
                /*{ "C Dur", Path.Combine(Program.appPath, "alarms", "cdur.mp3") },
                { "Guitar", Path.Combine(Program.appPath, "alarms", "guitarsolo.mp3") },
                { "Percussion", Path.Combine(Program.appPath, "alarms", "percussion.mp3") },*/
                { "Custom", Instance.customSoundPath }
            };
        }
        /*public static void Dump(string key, object value) {
            foreach (var field in Instance.GetType().GetFields()) {
                if (field.Name == key) {
                    field.SetValue(Instance, value);
                }
            }
            Write();
        }*/
    }
}
