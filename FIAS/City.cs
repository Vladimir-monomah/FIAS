using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS
{
    public class City
    {
        public void AttributeOutputCity(int OBJECT_NO, int COUNTRY_ID, int REGION_ID, int REGIONAREA_ID, int CITYTYPE_ID,
                       int MUNICIPALITYSTATUS_ID,
                       string CITY_FULLNAME,
                       string CITY_SHORTNAME,
                       string POST_OFFICE,
                       string DELIVERY_OFFICE,
                       int DELIVERYSERVICE_ID,
                       string EXTERNAL_ID,
                       string AOGUID,
                       int TYPE_NO,
                       int CREATOR_NO,
                       System.DateTime CREATED,
                       System.DateTime MODIFIED,
                       System.DateTime DELETED,
                       short IN_ARCHIVE,
                       string OBJECT_CODE,
                       string OBJECT_NAME,
                       decimal OBJECT_STATUS,
                       System.DateTime OBJECT_STATUSED,
                       short IS_PREFIX,
                       int VERSION_NO,
                       int MODIFIER_NO,
                       string OBJECT_STATUS_COMM)
        {
            var oracleConnection = new OracleConnection();
            oracleConnection = new OracleConnection("DATA SOURCE = IRBIS_E; USER ID = TTK_CRM_GROUP");
            oracleConnection.Open();
            OracleCommand addCommand;
            string MyCommand = "INSERT INTO TCITYЗапрос(AOGUID) VALUES(@OBJECT_NO, @CITYTYPE_ID, @MUNICIPALITYSTATUS_ID, @CITY_FULLNAME, " +
            "@CITY_SHORTNAME, @POST_OFFICE, @DELIVERY_OFFICE, @DELIVERYSERVICE_ID, @EXTERNAL_ID,@AOGUID,@TYPE_NO,@CREATOR_NO," +
            "@CREATED,@MODIFIED,@DELETED,@IN_ARCHIVE,@OBJECT_CODE,@OBJECT_NAME,@OBJECT_STATUS,@OBJECT_STATUSED,@IS_PREFIX,@VERSION_NO,@MODIFIER_NO,@OBJECT_STATUS_COMM)";

            addCommand = new OracleCommand(MyCommand, oracleConnection);
            addCommand.Parameters.Add("@OBJECT_NO", OBJECT_NO);
            addCommand.Parameters.Add("@CITYTYPE_ID", CITYTYPE_ID);
            addCommand.Parameters.Add("@MUNICIPALITYSTATUS_ID", MUNICIPALITYSTATUS_ID);
            addCommand.Parameters.Add("@CITY_FULLNAME", CITY_FULLNAME);
            addCommand.Parameters.Add("@CITY_SHORTNAME", CITY_SHORTNAME);
            addCommand.Parameters.Add("@POST_OFFICE", POST_OFFICE);
            addCommand.Parameters.Add("@DELIVERY_OFFICE", DELIVERY_OFFICE);
            addCommand.Parameters.Add("@DELIVERYSERVICE_ID", DELIVERYSERVICE_ID);
            addCommand.Parameters.Add("@EXTERNAL_ID,", EXTERNAL_ID);
            addCommand.Parameters.Add("@AOGUID", AOGUID);
            addCommand.Parameters.Add("@TYPE_NO", TYPE_NO);
            addCommand.Parameters.Add("@CREATOR_NO,", CREATOR_NO);
            addCommand.Parameters.Add("@CREATED", CREATED);
            addCommand.Parameters.Add("@MODIFIED", MODIFIED);
            addCommand.Parameters.Add("@DELETED", DELETED);
            addCommand.Parameters.Add("@IN_ARCHIVE", IN_ARCHIVE);
            addCommand.Parameters.Add("@OBJECT_CODE", OBJECT_CODE);
            addCommand.Parameters.Add("@OBJECT_NAME", OBJECT_NAME);
            addCommand.Parameters.Add("@OBJECT_STATUS", OBJECT_STATUS);
            addCommand.Parameters.Add("@OBJECT_STATUSED", OBJECT_STATUSED);
            addCommand.Parameters.Add("@IS_PREFIX", IS_PREFIX);
            addCommand.Parameters.Add("@VERSION_NO", VERSION_NO);
            addCommand.Parameters.Add("@MODIFIER_NO", MODIFIER_NO);
            addCommand.Parameters.Add("@OBJECT_STATUS_COMM", OBJECT_STATUS_COMM);
        }
    }
}
