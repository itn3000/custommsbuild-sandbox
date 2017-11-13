namespace CustomMsBuildTask1
{
    using MSBuild = Microsoft.Build.Framework;
    using MSBuildUtil = Microsoft.Build.Utilities;
    public class MyLibraryTestTask : MSBuildUtil.Task
    {
        public override bool Execute()
        {
            Log.LogMessage("mylib:{0}", MyLibrary.Class1.Hoge());
            Log.LogMessage("json:{0}", MyLibrary.Class1.Piyo());
            return true;
        }
    }
}