#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using FTOptix.Alarm;
using FTOptix.Recipe;
using FTOptix.DataLogger;
using FTOptix.Store;
using FTOptix.EventLogger;
using FTOptix.SQLiteStore;
using FTOptix.ODBCStore;
using FTOptix.Report;
using FTOptix.OPCUAServer;
using FTOptix.OPCUAClient;
using FTOptix.CommunicationDriver;
using FTOptix.Modbus;
using FTOptix.RAEtherNetIP;
using FTOptix.System;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
