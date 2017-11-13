using System;

namespace CustomMsBuildTask1
{
    using Newtonsoft.Json;
    using MSTask = Microsoft.Build.Utilities.Task;
    using MSBuild = Microsoft.Build.Framework;
    using System.Collections.Generic;

    public class JsonTestTaskFactory : MSBuild.ITaskFactory
    {
        public string FactoryName => nameof(JsonTestTaskFactory);

        public Type TaskType => typeof(JsonTestTask);

        public void CleanupTask(MSBuild.ITask task)
        {
        }

        public MSBuild.ITask CreateTask(MSBuild.IBuildEngine taskFactoryLoggingHost)
        {
            return new JsonTestTask();
        }

        public MSBuild.TaskPropertyInfo[] GetTaskParameters()
        {
            return new MSBuild.TaskPropertyInfo[0];
        }

        public bool Initialize(string taskName, IDictionary<string, MSBuild.TaskPropertyInfo> parameterGroup, string taskBody, MSBuild.IBuildEngine taskFactoryLoggingHost)
        {
            return true;
        }
    }
    public class JsonTestTask : MSTask
    {
        public override bool Execute()
        {
            Log.LogMessage("serialized value:{0}", Jil.JSON.Serialize(1));
            return true;
        }
    }
}
