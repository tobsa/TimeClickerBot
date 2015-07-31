using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClickerBot.Source
{
    public class WorkerHandler
    {
        private readonly Dictionary<string, Worker> workers = new Dictionary<string, Worker>();

        public void Register(string key, Worker worker)
        {
            workers.Add(key, worker);
        }

        public void Enable(string key)
        {
            workers[key].Enabled = true;
        }

        public void Disable(string key)
        {
            workers[key].Enabled = false;
        }

        public bool ToggleEnabled(string key)
        {
            workers[key].Enabled = !workers[key].Enabled;

            return workers[key].Enabled;
        }

        public void DisableAllExcept(string key)
        {
            foreach (var k in workers.Keys.Where(k => k != key))
                workers[k].Enabled = false;
        }

        public bool ActivateScript(string key)
        {
            DisableAllExcept(key);
            return ToggleEnabled(key);
        }

        public T GetScript<T>(string key) where T : Worker
        {
            if (!(workers[key] is T))
                return default(T);

            return (T) workers[key];
        }

        public void ReloadScript(string key, string filename)
        {
            workers[key] = new WorkerScript(filename);
        }
    }
}
