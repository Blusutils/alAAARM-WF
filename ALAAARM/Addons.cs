using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace alAAARM {
    public abstract class AssemblyFieldReader {
        public abstract object GetValue(string name);
    }
    public abstract class Addon : AssemblyFieldReader {
        /// <summary>
        /// Addon ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Addon name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Who is author of this addon
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Form with anything
        /// </summary>
        public Form MainForm { get; set; }

        /// <summary>
        /// Event what calls when addon loads
        /// </summary>
        public abstract void Load();
        /// <summary>
        /// Event what calls when addon unloads
        /// </summary>
        public abstract void Unload();
        
        public sealed override object GetValue(string name) {
            var field = GetType().GetField(name)?.GetValue(this);
            var prop = GetType().GetProperty(name)?.GetValue(this);
            return field??prop;
        }
    }

    internal class Addons {

        /// <summary>
        /// List of all addons
        /// </summary>
        private static List<Addon> AddonsList { get; set; } = new List<Addon>();

        /// <summary>
        /// Represent addons list in <see cref="TreeView"/>
        /// </summary>
        /// <param name="view">View where need to represent list</param>
        public static void Represent(TreeView view) {
            view.Nodes.Clear();
            AddonsList.ForEach(i => {
                view.Nodes.Add(i.GetValue("ID") as string, $"{i.GetValue("Name") as string} by {i.GetValue("Author") as string}", 0);
            });
        }

        /// <summary>
        /// Add an addon
        /// </summary>
        /// <param name="pathFrom">Path to addon to add</param>
        public static void LoadAddon(string pathFrom) {
            Assembly asm = Assembly.LoadFrom(pathFrom);
            string addonName = asm.ManifestModule.Name;
            try {
                var a = asm.CreateInstance($"{addonName.Substring(0, addonName.Length - 4)}.Entrypoint") as Addon;
                if (a == null) { MessageBox.Show($"Addon {addonName} is invalid (unable to find \"Entrypoint\" class)", "alAAARM", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                AddonsList.Add(a);
            } catch (InvalidCastException) { MessageBox.Show($"Addon {addonName} is invalid (\"Entrypoint\" class not derived from Addon)", "alAAARM", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public static void LoadAllAddonsFromDir(string targetDir) {
            foreach (var file in Directory.GetFiles(targetDir)) {
                if (File.Exists(file) && file.EndsWith(".dll")) {
                    LoadAddon(file);
                }
            }
        }
        /// <summary>
        /// Remove addon
        /// </summary>
        /// <param name="alarm">Target addon</param>
        public static void UnloadAddon(Addon alarm) {
            AddonsList.Remove(alarm);
        }
        /// <summary>
        /// Get list of all addons
        /// </summary>
        /// <returns><see cref="List{Addon}"/><see cref="Addon"/> List of addons</returns>
        public static List<Addon> GetAddons() {
            return AddonsList;
        }

        /// <summary>
        /// Find addon by ID
        /// </summary>
        /// <param name="id">Addon ID</param>
        /// <returns>Found <see cref="Addon"/> or null</returns>
        public static Addon FindAddonByID(string id) {
            foreach (var al in AddonsList) {
                if (al.GetValue("ID") as string == id) return al;
            }
            return null;
        }
        /// <summary>
        /// Find addon by name
        /// </summary>
        /// <param name="name">Addon name</param>
        /// <returns>Found <see cref="Addon"/> or null</returns>
        public static Addon FindAddonByName(string name) {
            foreach (var al in AddonsList) {
                if (al.GetValue("Name") as string == name) return al;
            }
            return null;
        }
    }
}
