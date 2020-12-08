using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS
{
    public class House
    {
        public void AttributeOutputHouse(int OBJECT_NO, int STREET_ID, int CORNER_STREET_ID, int COMPLEXNCH_ID,
                        int DISTRICT_ID,
                        int SECTOR_ID,
                        string HOUSE_NUMBER,
                        string CORNER_HOUSE_NUMBER,
                        string HOUSE_COMPLEX_NUMBER,
                        string BUILDING,
                        string CONSTRUCTION,
                        string POST_OFFICE,
                        string DELIVERY_OFFICE,
                        int APARTMENT_QUANTITY,
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
            string MyCommand = "INSERT INTO THOUSEЗапрос(AOGUID) VALUES(@OBJECT_NO, @COMPLEXNCH_ID,@DISTRICT_ID,@SECTOR_ID," +
            "@HOUSE_NUMBER,@CORNER_HOUSE_NUMBER,@HOUSE_COMPLEX_NUMBER,@BUILDING,@CONSTRUCTION,@POST_OFFICE,@DELIVERY_OFFICE," +
            "@APARTMENT_QUANTITY,@EXTERNAL_ID,@AOGUID,@TYPE_NO,@CREATOR_NO,@CREATED,@MODIFIED,@DELETED,@IN_ARCHIVE,@OBJECT_CODE," +
            "@OBJECT_NAME,@OBJECT_STATUS,@OBJECT_STATUSED,@IS_PREFIX,@VERSION_NO,@MODIFIER_NO,@OBJECT_STATUS_COMM)";

            addCommand = new OracleCommand(MyCommand, oracleConnection);
            addCommand.Parameters.Add("@OBJECT_NO", OBJECT_NO);
            addCommand.Parameters.Add("@COMPLEXNCH_ID", COMPLEXNCH_ID);
            addCommand.Parameters.Add("@DISTRICT_ID", DISTRICT_ID);
            addCommand.Parameters.Add("@SECTOR_ID", SECTOR_ID);
            addCommand.Parameters.Add("@HOUSE_NUMBER", HOUSE_NUMBER);
            addCommand.Parameters.Add("@CORNER_HOUSE_NUMBER", CORNER_HOUSE_NUMBER);
            addCommand.Parameters.Add("@HOUSE_COMPLEX_NUMBER", HOUSE_COMPLEX_NUMBER);
            addCommand.Parameters.Add("@BUILDING", BUILDING);
            addCommand.Parameters.Add(@"CONSTRUCTION", CONSTRUCTION);
            addCommand.Parameters.Add("@POST_OFFICE", POST_OFFICE);
            addCommand.Parameters.Add("@DELIVERY_OFFICE", DELIVERY_OFFICE);
            addCommand.Parameters.Add("@APARTMENT_QUANTITY", APARTMENT_QUANTITY);
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
