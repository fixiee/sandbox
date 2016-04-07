#region Script Metadata
/*
{
  "Description": ""
}
*/
#endregion Script Metadata

#region generated prefix code
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Interflex.IF6040.API;
using Interflex.IF6040.Foundation.ApplicationFramework.Interface;
using Interflex.IF6040.Foundation.Libraries.Authentication.Interface.DataObjects;
using Interflex.IF6040.Foundation.Libraries.Authentication.Interface;
using Interflex.IF6040.Foundation.Libraries.Base;
using Interflex.IF6040.Foundation.Libraries.Base.Time;
using Interflex.IF6040.Foundation.Libraries.Base.PropertyOperands;
using Interflex.IF6040.Foundation.Libraries.BaseData.Interface;
using Interflex.IF6040.Foundation.Libraries.BaseData.Implementation;
using Interflex.IF6040.Foundation.Libraries.ErrorManagement.Interface;
using Interflex.IF6040.Foundation.Libraries.Global;
using Interflex.IF6040.Foundation.Libraries.Global.Conditions;
using Interflex.IF6040.Foundation.Libraries.Global.Types;
using Interflex.IF6040.Foundation.Libraries.Globalization.Interface;
using Interflex.IF6040.Foundation.Libraries.Hierarchy.Interface;
using Interflex.IF6040.Foundation.Libraries.MessageQueuing.Interface;
using Interflex.IF6040.Foundation.Libraries.NocFacilityHandling.Interface;
using Interflex.IF6040.Foundation.Libraries.NocFacilityHandling.Interface.Implementation;
using Interflex.IF6040.Foundation.Services.Auditing.Implementation.DataObjects;
using Interflex.IF6040.Foundation.Services.Auditing.Interface;
using Interflex.IF6040.Foundation.Services.DataEngine.DataDefinition;
using Interflex.IF6040.Foundation.Services.DataEngine.DataScopes;
using Interflex.IF6040.Foundation.Services.DataEngine.DataSelection;
using Interflex.IF6040.Foundation.Services.PerfCount.Interface.Attributes;
using Interflex.IF6040.Foundation.Services.PerfCount.Interface.Configuration;
using Interflex.IF6040.Foundation.Services.PerfCount.Interface.Interfaceimplementation;
using Interflex.IF6040.Foundation.Services.PerfCount.Interface;
using Interflex.IF6040.Foundation.Services.Periphery.Global;
using Interflex.IF6040.Foundation.Services.Runtime.Configuration;
using Interflex.IF6040.Foundation.Services.Security.AccessControl.Interface.DataObjects;
using Interflex.IF6040.Foundation.Services.Security.AccessControl;
using Interflex.IF6040.Foundation.Services.Security.Server;
using Interflex.IF6040.Foundation.Services.Security.Server.Permissions;
using Interflex.IF6040.Foundation.Services.Synchronization.Interface;
using Interflex.IF6040.Foundation.Services.Workflow.Global;
using Interflex.IF6040.Foundation.Services.Workflow.Interface;
using Interflex.IF6040.Foundation.Services.WorkflowProxy.Interface.Base;
using Interflex.IF6040.Foundation.Services.WorkflowProxy.Interface.Data;
using Interflex.IF6040.Foundation.Services.WorkflowProxy.Interface;
using Interflex.IF6040.Foundation.Tools.Crypter.SymmetricCrypter;
using Interflex.IF6040.Modules.AccessRights.Interface;
using Interflex.IF6040.Modules.BookingProcessing.Interface.Common;
using Interflex.IF6040.Modules.BookingProcessing.Interface;
using Interflex.IF6040.Modules.CustomerExtensions.Interface;
using Interflex.IF6040.Modules.DataExchange.Interface.DataObjects;
using Interflex.IF6040.Modules.DataExchange.Interface.DataObjects.Transport;
using Interflex.IF6040.Modules.DataExchange.Interface;
using Interflex.IF6040.Modules.HumanResources.Interface;
using Interflex.IF6040.Modules.HumanResources.Interface.DataObjects;
using Interflex.IF6040.Modules.IfTerapiClient.Interface;
using Interflex.IF6040.Modules.Monitoring.AlarmArchive.Interface;
using Interflex.IF6040.Modules.Monitoring.Configuration.Interface;
using Interflex.IF6040.Modules.Monitoring.Globals;
using Interflex.IF6040.Modules.Peripherie.Download.Administration.Interface;
using Interflex.IF6040.Modules.Peripherie.Download.ConverterNT.Interface;
using Interflex.IF6040.Modules.Peripherie.Download.Parameter.Interface;
using Interflex.IF6040.Modules.Peripherie.Download.Persistence.Interface;
using Interflex.IF6040.Modules.Peripherie.Download.Service.Interface;
using Interflex.IF6040.Modules.Peripherie.Libaries.AreaCode.Interface;
using Interflex.IF6040.Modules.Peripherie.Libraries.PeripherieLibrary.Interface;
using Interflex.IF6040.Modules.Peripherie.Libraries.PSConfiguration.Interface;
using Interflex.IF6040.Modules.Peripherie.NetworkOnMobile.Interface;
using Interflex.IF6040.Modules.PeripheryAdapter.Interface;
using Interflex.IF6040.Modules.PlanEntryAudit.Interface.DataObjects;
using Interflex.IF6040.Modules.PlanEntryAudit.Interface;
using Interflex.IF6040.Modules.QualityManagement.Interface;
using Interflex.IF6040.Modules.Recording.PersonEvents.Global.EventProcessing;
using Interflex.IF6040.Modules.Recording.PersonEvents.Global.Exceptions;
using Interflex.IF6040.Modules.Recording.PersonEvents.Interface.Accounts.DO;
using Interflex.IF6040.Modules.Recording.PersonEvents.Interface.Defs.DO;
using Interflex.IF6040.Modules.Recording.PersonEvents.Interface.DataObjects;
using Interflex.IF6040.Modules.Recording.PersonEvents.Interface.State.DO;
using Interflex.IF6040.Modules.Recording.PersonEvents.Interface;
using Interflex.IF6040.Modules.Recording.PersonEvents.Interface.Permission;
using Interflex.IF6040.Modules.Recording.PersonEvents.Interface.Manager;
using Interflex.IF6040.Modules.Recording.PersonEvents.Interface.State;
using Interflex.IF6040.Modules.Scheduling.Interface.DataObjects;
using Interflex.IF6040.Modules.Scripting.Implementation;
using Interflex.IF6040.Modules.Scripting.Interface;
using Interflex.IF6040.Modules.Security.Global;
using Interflex.IF6040.Modules.Security.Global.Enums;
using Interflex.IF6040.Modules.Security.Interface.DataObjects;
using Interflex.IF6040.Modules.Security.Interface.NoC;
using Interflex.IF6040.Modules.Security.Interface.AccessArchive;
using Interflex.IF6040.Modules.Security.Interface.AccessModule;
using Interflex.IF6040.Modules.Security.Interface.AccessTree;
using Interflex.IF6040.Modules.Security.Interface.Employee;
using Interflex.IF6040.Modules.Security.Interface;
using Interflex.IF6040.Modules.Security.Interface.HardwareFeatures;
using Interflex.IF6040.Modules.Security.Interface.Online;
using Interflex.IF6040.Modules.Security.Interface.SpecDays;
using Interflex.IF6040.Modules.Security.Interface.Syspar;
using Interflex.IF6040.Modules.Ta.Interface.DataObjects;
using Interflex.IF6040.Modules.Ta.Interface;
using Interflex.IF6040.Modules.Ta.Interface.Extensions;
using Interflex.IF6040.Modules.Ta.Interface.Parser.Exceptions;
using Interflex.IF6040.Modules.Ta.Interface.Scheduling;
using Interflex.IF6040.Modules.Ta.Interface.Scheduling.Exceptions;
using Interflex.IF6040.Modules.Ta.Interface.Scheduling.Extensions;
using Interflex.IF6040.Modules.Ta.Interface.TaServerAdapter;
using Interflex.IF6040.Modules.Ta.Interface.Parser;
using Interflex.IF6040.Modules.Taskflow.Interface.DataObjects;
using Interflex.IF6040.Modules.Taskflow.Interface.Requests;
using Interflex.IF6040.Modules.Taskflow.Interface;
using Interflex.IF6040.Modules.UIConfiguration.Interface.ColumnDefinition;
using Interflex.IF6040.Modules.UIConfiguration.Interface;
using Interflex.IF6040.Modules.UIConfiguration.Interface.WorkingSet;
using Interflex.IF6040.Modules.Vehicles.Interface;
using Interflex.IF6040.Modules.Visitor.Interface;
using Interflex.IF6040.Modules.Workflow.Interface;
using Interflex.IF6040.Modules.WorkflowActivities.Interface;
using Interflex.IF6040.Security.Utilities;
using Interflex.IF6040.ServiceLayer.Auditing.Interface;
using Interflex.IF6040.Servicelayer.Authentication.Interface;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Implementation;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.TestTransferObjects;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.SyncManagerObjects;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.Authorization;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.BaseDataExtensions;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.DataEntrys;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.DataProperties;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.HierarchyServiceTransferObjects;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.QueryObjects;
using Interflex.IF6040.ServiceLayer.BaseDataServices.Interface.QueryObjects.GroupOperations;
using Interflex.IF6040.ServiceLayer.BaseServices.Implementation;
using Interflex.IF6040.ServiceLayer.BaseServices.Interface.Wcf;
using Interflex.IF6040.ServiceLayer.BaseServices.Interface;
using Interflex.IF6040.ServiceLayer.BaseServices.Interface.Context;
using Interflex.IF6040.ServiceLayer.BaseServices.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.BookingProcessing.Interface;
using Interflex.IF6040.ServiceLayer.CustomerExtensions.Interface;
using Interflex.IF6040.ServiceLayer.DataExchange.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.DataExchange.Interface.TransferObjects.Transport;
using Interflex.IF6040.ServiceLayer.DataExchange.Interface;
using Interflex.IF6040.ServiceLayer.DataObjectTypeHandlers.Interface;
using Interflex.IF6040.ServiceLayer.DayTypes.Interface;
using Interflex.IF6040.ServiceLayer.Download.Interface;
using Interflex.IF6040.ServiceLayer.Monitoring.Actions.Interface;
using Interflex.IF6040.ServiceLayer.Monitoring.AlarmArchive.Interface;
using Interflex.IF6040.ServiceLayer.Monitoring.Configuration.Interface;
using Interflex.IF6040.ServiceLayer.Monitoring.EventSource.Interface;
using Interflex.IF6040.ServiceLayer.Monitoring.Simulation.Interface;
using Interflex.IF6040.ServiceLayer.NetworkOnMobile.Interface;
using Interflex.IF6040.ServiceLayer.PeripheralsServer.Interface;
using Interflex.IF6040.ServiceLayer.PeripheralsServerRemote.Interface;
using Interflex.IF6040.ServiceLayer.PeripheryAdapter.Interface;
using Interflex.IF6040.ServiceLayer.PlanEntryAudit.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.QualityManagement.QualityManagement.Interface;
using Interflex.IF6040.ServiceLayer.QualityManagement.Interface;
using Interflex.IF6040.ServiceLayer.Recording.PersonEvents.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.Recording.PersonEvents.Interface.Accounts.TO;
using Interflex.IF6040.ServiceLayer.Recording.PersonEvents.Interface.State.TO;
using Interflex.IF6040.ServiceLayer.Recording.PersonEvents.Interface.Defs.TO;
using Interflex.IF6040.ServiceLayer.Recording.PersonEvents.Interface.Permission;
using Interflex.IF6040.ServiceLayer.Recording.PersonEvents.Interface;
using Interflex.IF6040.ServiceLayer.Security.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.Scheduling.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.Scheduling.Interface;
using Interflex.IF6040.ServiceLayer.Scripting.Implementation;
using Interflex.IF6040.ServiceLayer.Scripting.Interface;
using Interflex.IF6040.ServiceLayer.SearchServices.Interface;
using Interflex.IF6040.ServiceLayer.SearchServicesRemote.Interface;
using Interflex.IF6040.ServiceLayer.Security.Actions.Interface;
using Interflex.IF6040.ServiceLayer.Security.Interface.CredentialProduction;
using Interflex.IF6040.ServiceLayer.Security.Interface.Employee;
using Interflex.IF6040.ServiceLayer.Security.Interface;
using Interflex.IF6040.ServiceLayer.Security.Interface.TansferObjects;
using Interflex.IF6040.ServiceLayer.Ta.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.Ta.Interface;
using Interflex.IF6040.ServiceLayer.Taskflow.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.Taskflow.Interface;
using Interflex.IF6040.ServiceLayer.UIConfigurationServices.Interface;
using Interflex.IF6040.ServiceLayer.UIConfigurationServices.Interface.TransferObjects;
using Interflex.IF6040.ServiceLayer.Vehicles.Interface;
using Interflex.IF6040.ServiceLayer.VisitorServices.Interface;
using Interflex.IF6040.ServiceLayer.Workflow.Interface;
using Interflex.IF6040.ServiceLayer.Workflow.Interface.Api;
using Interflex.IF6040.ServiceLayer.Workflow.Interface.TransferObjects;

namespace Interflex.IF6040.Modules.Scripting
{
    public class Create_Download_Job : Interflex.IF6040.Modules.Scripting.Interface.ScriptBase
    {
        
#endregion generated prefix code

        public override void Process()
        {

            var job = Api.Transaction.Data.IF_automaticjobs.Select(BOP.IF_automaticjob.ajdesc == "TLA_X").FirstOrDefault();
            if (job == null)
            {
                ScriptResult += "error";
                return;
            }
            

            foreach (var bote in Api.Transaction.Data.IF_portdefs.Select(BOP.IF_portdef.podesc.Like("TBS%")))
            {
                var entry = Api.Transaction.Data.AutojobContrs.New();
                entry.AutojobDOR = job;
                entry.BaseAreaTreeElementDOR = bote;
                Api.Transaction.Store(entry);
            }
            Api.Transaction.Publish();


        }



        #region generated suffix code 
    }
}
#endregion generated suffix code