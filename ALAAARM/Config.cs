using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace alAAARM {
    internal class Config {

        private int _soundVolume = 0;
        public int soundVolume { get => _soundVolume; set { _soundVolume = value; Write(); } }
        private string _selectedSound = "Beep Beep Beep";
        public string selectedSound { get => _selectedSound; set { _selectedSound = value; Write(); } }
        private string _customSoundPath = "";
        public string customSoundPath { get => _customSoundPath; set { _customSoundPath = value; Write(); } }
        private bool _useRelativeTime = true;
        public bool useRelativeTime { get => _useRelativeTime; set { _useRelativeTime = value; Write(); } }

        [JsonIgnore]
        public static Dictionary<string, string> alarmSoundsPathes;
        [JsonIgnore]
        public static Config Instance;

        [JsonConstructor]
        Config() { }

        private static void Write() {
            File.WriteAllText("./config.json", JsonConvert.SerializeObject(Instance, Formatting.Indented));
        }
        public static void Load() {
            if (File.Exists("./config.json")) {
                Instance = JsonConvert.DeserializeObject<Config>(File.ReadAllText("./config.json"));
            } else {
                Instance = new Config();
                Write();
            }
            var appPath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location), "");
            alarmSoundsPathes = new Dictionary<string, string>() {
                { "Beep Beep Beep", Path.Combine(appPath, "alarms", "beepbeepbeep.mp3") },
                { "Beep Beep Beep Alternate", Path.Combine(appPath, "alarms", "beepbeepbeep2.mp3") },
                { "Alarm clock", Path.Combine(appPath, "alarms", "alarmclock.mp3") },
                { "Sinusoid", Path.Combine(appPath, "alarms", "sinusoid.mp3") },
                /*{ "C Dur", Path.Combine(appPath, "alarms", "cdur.mp3") },
                { "Guitar", Path.Combine(appPath, "alarms", "guitarsolo.mp3") },
                { "Percussion", Path.Combine(appPath, "alarms", "percussion.mp3") },*/
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
