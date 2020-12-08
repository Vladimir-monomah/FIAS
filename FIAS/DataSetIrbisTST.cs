namespace FIAS
{


    partial class DataSetIrbisTST
    {
        partial class TSTREETЗапросDataTable
        {
            void AttributeOutputStreet(int OBJECT_NO, int CITY_ID, int TOWN_ID, int STREETTYPE_ID,
                        string STREET_NAME,
                        string POST_OFFICE,
                        string DELIVERY_OFFICE,
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
                string text = "INSERT INTO TSTREETЗапрос() VALUES (@OBJECT_NO, @STREETTYPE_ID,@STREET_NAME,@POST_OFFICE,@DELIVERY_OFFICE,@EXTERNAL_ID,@AOGUID," +
                    "@TYPE_NO,@CREATOR_NO,@CREATED,@MODIFIED,@DELETED,@IN_ARCHIVE,@OBJECT_CODE,@OBJECT_NAME,@OBJECT_STATUS,@OBJECT_STATUSED,@IS_PREFIX,@VERSION_NO," +
                    "@MODIFIER_NO,@OBJECT_STATUS_COMM)";
            }
        }
    }
}

namespace FIAS.DataSetIrbisTSTTableAdapters
{
    partial class THOUSEЗапросTableAdapter
    {
        void AttributeOutputHouse(int OBJECT_NO, int STREET_ID, int CORNER_STREET_ID, int COMPLEXNCH_ID,
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
            string text = "INSERT INTO THOUSEЗапрос() VALUES(@OBJECT_NO, @COMPLEXNCH_ID,@DISTRICT_ID,@SECTOR_ID," +
                "@HOUSE_NUMBER,@CORNER_HOUSE_NUMBER,@HOUSE_COMPLEX_NUMBER,@BUILDING,@CONSTRUCTION,@POST_OFFICE,@DELIVERY_OFFICE," +
                "@APARTMENT_QUANTITY,@EXTERNAL_ID,@AOGUID,@TYPE_NO,@CREATOR_NO,@CREATED,@MODIFIED,@DELETED,@IN_ARCHIVE,@OBJECT_CODE," +
                "@OBJECT_NAME,@OBJECT_STATUS,@OBJECT_STATUSED,@IS_PREFIX,@VERSION_NO,@MODIFIER_NO,@OBJECT_STATUS_COMM)";
        }
    }

    partial class TCITYЗапросTableAdapter
    {
        void AttributeOutputCity(int OBJECT_NO, int COUNTRY_ID, int REGION_ID, int REGIONAREA_ID, int CITYTYPE_ID,
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
            string text = "INSERT INTO TCITYЗапрос() VALUES(@OBJECT_NO, @CITYTYPE_ID, @MUNICIPALITYSTATUS_ID, @CITY_FULLNAME, " +
                "@CITY_SHORTNAME, @POST_OFFICE, @DELIVERY_OFFICE, @DELIVERYSERVICE_ID, @EXTERNAL_ID,@AOGUID,@TYPE_NO,@CREATOR_NO," +
                "@CREATED,@MODIFIED,@DELETED,@IN_ARCHIVE,@OBJECT_CODE,@OBJECT_NAME,@OBJECT_STATUS,@OBJECT_STATUSED,@IS_PREFIX,@VERSION_NO,@MODIFIER_NO,@OBJECT_STATUS_COMM)";
        }
    }

    public partial class TREGIONAREAЗапросTableAdapter
    {
        void AttributeOutputRegion(int OBJECT_NO, int REGION_ID, int REGIONAREATYPE_ID, string REGIONAREA_FULLNAME, string REGIONAREA_SHORTNAME,
                        string POST_OFFICE,
                        string DELIVERY_OFFICE,
                        string EXTERNAL_ID,
                        string AOGUID,
                        int TYPE_NO,
                        int CREATOR_NO, System.DateTime CREATED,
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
            string text = "INSERT INTO TREGIONAREAЗапрос() VALUES (@OBJECT_NO,@REGIONAREATYPE_ID,@REGIONAREA_FULLNAME, " +
                "@REGIONAREA_SHORTNAME,@POST_OFFICE,@DELIVERY_OFFICE,@EXTERNAL_ID,@AOGUID,@TYPE_NO,@CREATOR_NO,@CREATED,@MODIFIED,@DELETED," +
                "@IN_ARCHIVE,@OBJECT_CODE,@OBJECT_NAME,@OBJECT_STATUS,@OBJECT_STATUSED,@IS_PREFIX,@VERSION_NO,@MODIFIER_NO,@OBJECT_STATUS_COMM)";
        }
    }
}
