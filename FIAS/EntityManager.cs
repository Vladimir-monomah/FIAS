using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using FIAS.DataSetIrbisTSTTableAdapters;
using static FIAS.DataSetIrbisTST;

namespace FIAS
{
    public class EntityManager
    {
        static DataSetIrbisTST DataSetIrbisTST = new DataSetIrbisTST();

        private static REGISTRATIONTableAdapter REGISTRATIONTableAdapter = new REGISTRATIONTableAdapter();
        private static TREGIONAREATableAdapter TREGIONAREATableAdapter = new TREGIONAREATableAdapter();
        private static TCITYTableAdapter TCITYTableAdapter = new TCITYTableAdapter();
        private static TSTREETTableAdapter TSTREETTableAdapter = new TSTREETTableAdapter();
        private static THOUSETableAdapter THOUSETableAdapter = new THOUSETableAdapter();

        public static REGISTRATIONDataTable UserDataTable
        {
            get
            {
                return DataSetIrbisTST.REGISTRATION;
            }
        }

        public static TREGIONAREADataTable TREGIONAREADataTable
        {
            get
            {
                return DataSetIrbisTST.TREGIONAREA;
            }
        }

        public static TCITYDataTable TCITYDataTable
        {
            get
            {
                return DataSetIrbisTST.TCITY;
            }
        }

        public static TSTREETDataTable TSTREETDataTable
        {
            get
            {
                return DataSetIrbisTST.TSTREET;
            }
        }

        public static THOUSEDataTable THOUSEDataTable
        {
            get
            {
                return DataSetIrbisTST.THOUSE;
            }
        }

        public static void UpdateUsers()
        {
            REGISTRATIONTableAdapter.Adapter.Update(UserDataTable);
        }

        public static void UpdateTREGIONAREA()
        {
            TREGIONAREATableAdapter.Adapter.Update(TREGIONAREADataTable);
        }

        public static void UpdateTCITY()
        {
            TCITYTableAdapter.Adapter.Update(TCITYDataTable);
        }

        public static void UpdateTSTREET()
        {
            TSTREETTableAdapter.Adapter.Update(TSTREETDataTable);
        }

        public static void UpdateTHOUSE()
        {
            THOUSETableAdapter.Adapter.Update(THOUSEDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу пользователей по условию <paramref name="condition">
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static REGISTRATIONDataTable FilterUsers(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OracleCommand()
            {
                Connection = REGISTRATIONTableAdapter.Connection,
                CommandText = "SELECT SERNAME, NAME, PATRONOMIC, LOGIN, PASSWORD " +
            $"FROM REGISTRATION {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(REGISTRATIONTableAdapter.Adapter, filterEmployeesCommand, UserDataTable);

            return UserDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу районов по условию <paramref name="condition">
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static TREGIONAREADataTable FilterTREGIONAREA(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OracleCommand()
            {
                Connection = TREGIONAREATableAdapter.Connection,
                CommandText = "OBJECT_NO, AOGUID " +
            $"FROM BILLING.TREGIONAREA {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(TREGIONAREATableAdapter.Adapter, filterEmployeesCommand, TREGIONAREADataTable);

            return TREGIONAREADataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу городов по условию <paramref name="condition">
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static TCITYDataTable FilterTCITY(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OracleCommand()
            {
                Connection = TCITYTableAdapter.Connection,
                CommandText = "OBJECT_NO, AOGUID " +
            $"FROM BILLING.TCITY {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(TCITYTableAdapter.Adapter, filterEmployeesCommand, TCITYDataTable);

            return TCITYDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу улиц по условию <paramref name="condition">
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static TSTREETDataTable FilterTSTREET(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OracleCommand()
            {
                Connection = TSTREETTableAdapter.Connection,
                CommandText = "OBJECT_NO, AOGUID " +
            $"FROM BILLING.TSTREET {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(TSTREETTableAdapter.Adapter, filterEmployeesCommand, TSTREETDataTable);

            return TSTREETDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу домов по условию <paramref name="condition">
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static THOUSEDataTable FilterTHOUSE(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterEmployeesCommand = new OracleCommand()
            {
                Connection = THOUSETableAdapter.Connection,
                CommandText = "OBJECT_NO, AOGUID " +
            $"FROM BILLING.THOUSE {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(THOUSETableAdapter.Adapter, filterEmployeesCommand, THOUSEDataTable);

            return THOUSEDataTable;
        }

        /// <summary>
        /// Создает строку для фильтрации: всевозможные комбинации по сравнению предоставленных полей с текстом поиска
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public static string GetFilterStringByFields(string[] fields, string searchText)
        {
            var findValues = string.IsNullOrEmpty(searchText)
            ? new string[] { }
            : searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filterStrings = new List<string>();
            foreach (var findingField in fields)
            {
                foreach (var findingValue in findValues)
                {
                    filterStrings.Add($"{findingField} LIKE '%{findingValue}%'");
                }
            }

            return string.Join(" OR ", filterStrings);
        }

        /// <summary>
        /// Заполняет таблицу по фильтрующей команде выбора строк
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="selectCommand"></param>
        /// <param name="table"></param>
        private static void FillFilteredTable(OracleDataAdapter adapter, OracleCommand selectCommand, DataTable table)
        {
            var orkSelectComand = adapter.SelectCommand;
            adapter.SelectCommand = selectCommand;

            table.Clear();

            adapter.Fill(table);
            adapter.SelectCommand = orkSelectComand;
        }
    }
}
