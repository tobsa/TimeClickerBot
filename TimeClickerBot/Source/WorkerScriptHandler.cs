using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClickerBot.Source
{
    public class WorkerScriptHandler
    {
        private readonly Dictionary<string, BaseWorkerScript> workerScripts = new Dictionary<string, BaseWorkerScript>(); 

        public void Register(string key, BaseWorkerScript workerScript)
        {
            workerScripts.Add(key, workerScript);
        }

        public bool ActivateScript(string key)
        {
            DisableAllExcept(key);
            return ToggleEnabled(key);
        }

        public void DisableAllExcept(string key)
        {
            foreach (var k in workerScripts.Keys.Where(k => k != key))
                workerScripts[k].Enabled = false;
        }

        public bool ToggleEnabled(string key)
        {
            workerScripts[key].Enabled = !workerScripts[key].Enabled;

            return workerScripts[key].Enabled;
        }

        public T GetWorkerScript<T>(string key) where T : BaseWorkerScript
        {
            return workerScripts[key] as T;
        }

        public void ReloadScript(string key, BaseWorkerScript script)
        {
            workerScripts[key] = script;
        }
    }
}
