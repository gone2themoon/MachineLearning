using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace Oven_AI
{
    class ManufacturingExecution
    {
        // Set Instance of NLOG
        private static Logger logger = LogManager.GetCurrentClassLogger();

        //public bool changeProduction(string newRouter, string designatedOperation, string[] sfclist, ref string sResult)
        //{
        //    try
        //    {
        //        ChangeProductionServiceWSService.ChangeProductionServiceWS proxy = new ChangeProductionServiceWSService.ChangeProductionServiceWS();

        //        ////filling user credential for the web service
        //        proxy.Credentials = new System.Net.NetworkCredential(_mesUname, _mesPwd);
        //        proxy.PreAuthenticate = true;

        //        //ChangeProductionServiceWSService.ChangeProductionRequest
        //        ChangeProductionServiceWSService.ChangeProductionRequest request = new ChangeProductionServiceWSService.ChangeProductionRequest();
        //        ChangeProductionServiceWSService.changeProductionResponse response = new ChangeProductionServiceWSService.changeProductionResponse();
        //        ChangeProductionServiceWSService.changeProduction req = new ChangeProductionServiceWSService.changeProduction();
        //        ChangeProductionServiceWSService.ChangeProductionContext context = new ChangeProductionServiceWSService.ChangeProductionContext();

        //        context.newRouter = newRouter;// "GOLD_SOL3_1_PROD";
        //        request.changeProductionContextType = context;

        //        request.operationPlacementType = 0;
        //        request.designatedOperation = designatedOperation;// "PCK";
        //        request.sfcList = sfclist;
        //        request.allowDoneSfcs = true;
        //        request.allowDoneSfcsSpecified = true;//not in old program
        //        request.allowPackedSfcs = true;
        //        //request.allowReworkSfcRouterChange = true;
        //        request.adjustBuildOrderQuantity = false;
        //        request.operationPlacementTypeSpecified = true;

        //        req.Site = site;
        //        req.Request = request;

        //        response = proxy.changeProduction(req);

        //        sResult = "Change Production Successful.";
        //        return true;
        //    }

        //    catch (Exception ex)
        //    {
        //        sResult = ex.Message;
        //        return false;
        //    }
        //}


        public bool NCLog(String sResp, string sfc, string resource)
        {
            try
            {
                logger.Trace(sfc + " - Failed to process and has been scrapped");
        
        ///###
        /// Need to import the webservice.
        /// Name for WS: iemames001_ProductionServiceService
        /// http://iemames011:8000/manufacturing-services/ProductionServiceService?wsdl
        /// ###

        //filling user credential for the web service
        // iemames001_ProductionServiceService.ProductionServiceService proxy = new iemames001_ProductionServiceService.ProductionServiceService();

        //proxy.Credentials = new System.Net.NetworkCredential("MESYS", "icc8336");
        //proxy.PreAuthenticate = true;
        //proxy.Url = "http://iemames001:50000/manufacturing-services/ProductionServiceService?wsdl";
        //proxy.Url = "http://ieabmes011:8000/manufacturing-services/ProductionServiceService?wsdl";

        // create objects for the W/S Request.
        iemames001_ProductionServiceService.NCLogRequestMessage_sync request = new iemames001_ProductionServiceService.NCLogRequestMessage_sync();
                iemames001_ProductionServiceService.NCLogConfirmationMessage_sync response = new iemames001_ProductionServiceService.NCLogConfirmationMessage_sync();
                iemames001_ProductionServiceService.NCCodeRef NCodeRef = new iemames001_ProductionServiceService.NCCodeRef();
                iemames001_ProductionServiceService.NCDataRef NDataRef = new iemames001_ProductionServiceService.NCDataRef();
                iemames001_ProductionServiceService.NCContext NCContext = new iemames001_ProductionServiceService.NCContext();
                iemames001_ProductionServiceService.NCLogRequest NCodeDefIn = new iemames001_ProductionServiceService.NCLogRequest();
                iemames001_ProductionServiceService.LEN20Name NCLocation = new iemames001_ProductionServiceService.LEN20Name();
                iemames001_ProductionServiceService.LEN60Name NCCustDataAttrib = new iemames001_ProductionServiceService.LEN60Name();
                iemames001_ProductionServiceService.INTEGERQuantity DefectCount = new iemames001_ProductionServiceService.INTEGERQuantity();
                iemames001_ProductionServiceService.SHORTName NCCode = new iemames001_ProductionServiceService.SHORTName();
                iemames001_ProductionServiceService.Text Comment = new iemames001_ProductionServiceService.Text();
                iemames001_ProductionServiceService.Text Value = new iemames001_ProductionServiceService.Text();
                iemames001_ProductionServiceService.Description Description = new iemames001_ProductionServiceService.Description();
                iemames001_ProductionServiceService.NCLog[] NLog = new iemames001_ProductionServiceService.NCLog[1];
                NLog[0] = new iemames001_ProductionServiceService.NCLog();

                //' NC Custom Data
                iemames001_ProductionServiceService.CustomField[] NCCustomData = new iemames001_ProductionServiceService.CustomField[1];
                NCCustomData[0] = new iemames001_ProductionServiceService.CustomField();

                //' Setup Parameters

                //' Site
                iemames001_ProductionServiceService.SiteRef SiteRef = new iemames001_ProductionServiceService.SiteRef();
                SiteRef.Site = "0007";

                //' SFC
                iemames001_ProductionServiceService.SFCRef SFCRef = new iemames001_ProductionServiceService.SFCRef();
                SFCRef.Sfc = sfc;
                SFCRef.SiteRef = SiteRef;

                //' Operation
                iemames001_ProductionServiceService.OperationRef OperationRef = new iemames001_ProductionServiceService.OperationRef();
                OperationRef.Operation = "OIA_T";
                OperationRef.SiteRef = SiteRef;

                //' Resource
                iemames001_ProductionServiceService.ResourceID ResourceIDRef = new iemames001_ProductionServiceService.ResourceID();
                //ResourceIDRef.Value = Properties.Settings.Default.sapme_Resource_1; 
                ResourceIDRef.Value = resource;

                iemames001_ProductionServiceService.ResourceRef ResourceRef = new iemames001_ProductionServiceService.ResourceRef();
                ResourceRef.Resource = ResourceIDRef;
                ResourceRef.SiteRef = SiteRef;

                //' User
                iemames001_ProductionServiceService.UserRef UserRef = new iemames001_ProductionServiceService.UserRef();
                UserRef.UserId = "MESYS";

                //' Owner
                iemames001_ProductionServiceService.Owner NCOwner = new iemames001_ProductionServiceService.Owner();
                NCOwner.UserRef = UserRef;
                NCOwner.UserRef.SiteRef = SiteRef;

                //' NCLog Request
                iemames001_ProductionServiceService.NCLogRequest NCLogRequest = new iemames001_ProductionServiceService.NCLogRequest();

                //' Fill Variables
                NCCode.Value = sfc; //FailInfo.NCCode;
                Comment.Value = "FAILED";
                iemames001_ProductionServiceService.SHORTName NC_Code = new iemames001_ProductionServiceService.SHORTName();
                //NC_Code.Value = sfc.NC_Code;
                NCodeRef.NcCode = NC_Code;
                NCContext.SfcRef = SFCRef;
                NCLocation.Value = "1";
                DefectCount.Value = 1;

                //' Fill Fail Data
                string attr = "TEST_STEP";

                Description.Value = "TEMP";

                NCCustDataAttrib.Value = attr;
                NCCustomData[0].Attribute = NCCustDataAttrib;
                NCCustomData[0].Description = Description;
                NCCustomData[0].Value = Value;

                NLog[0].SiteRef = SiteRef;
                NLog[0].OperationRef = OperationRef;
                NLog[0].ComponentSfc = SFCRef;
                NLog[0].ResourceRef = ResourceRef;
                NLog[0].NcOwner = NCOwner;
                NLog[0].Comments = Comment;
                NLog[0].NcCodeRef = NCodeRef;
                NLog[0].NcContext = NCContext;
                NLog[0].Location = NCLocation;
                NLog[0].RefDes = "TEMP";
                NLog[0].DefectCount = DefectCount;
                NLog[0].NcCustomData = NCCustomData;

                // Fill NCLogRequest
                NCLogRequest.SiteRef = SiteRef;
                NCLogRequest.NcLog = NLog;

                // Fill request
                request.NCLogRequest = NCLogRequest;

                // Call Method of WebService
               // response = proxy.LogNC(request);

                return true;
            }
            catch (Exception ex)
            {
                sResp = ex.Message;
                return false;
            }
        }
    }
}
