using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Coursework.Classes
{
    public static class SQLCommands {
        public static string AddSupplier(
            string fio,
            string phone,
            string address,
            string email,
            SqlConnection connection
        ) {
            var command = new SqlCommand("sp_AddSupplier", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var fioParam = new SqlParameter {
                ParameterName = "@SupFIO",
                Value = fio
            };

            var phoneParam = new SqlParameter {
                ParameterName = "@SupTelNumber",
                Value = phone
            };

            var addressParam = new SqlParameter {
                ParameterName = "@SupAdress",
                Value = address
            };

            var emailParam = new SqlParameter {
                ParameterName = "@SupEmail",
                Value = email
            };

            command.Parameters.Add(fioParam);
            command.Parameters.Add(phoneParam);
            command.Parameters.Add(addressParam);
            command.Parameters.Add(emailParam);

            try {
                command.ExecuteNonQuery();
                return null;
            }
            catch (SqlException ex) {
                return "Ошибка при добавлении поставщика";
            }
        }

        public static string AddCustomer(
            string fio,
            string phone,
            string address,
            string email,
            SqlConnection connection
        ) {
            var command = new SqlCommand("sp_AddCustomer", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var fioParam = new SqlParameter {
                ParameterName = "@CusFIO",
                Value = fio
            };

            var phoneParam = new SqlParameter {
                ParameterName = "@CusTelNumber",
                Value = phone
            };

            var addressParam = new SqlParameter {
                ParameterName = "@CusAddress",
                Value = address
            };

            var emailParam = new SqlParameter {
                ParameterName = "@CusEmail",
                Value = email
            };

            command.Parameters.Add(fioParam);
            command.Parameters.Add(phoneParam);
            command.Parameters.Add(addressParam);
            command.Parameters.Add(emailParam);

            try {
                command.ExecuteNonQuery();
                return null;
            }
            catch (SqlException ex) {
                return "Ошибка при добавлении заказчика";
            }
        }

        public static string AddCusDeclar(
            string TypeDec,
            int NumbSupply,
            int QuantityProd,
            int IdTransportOutCountry,
            int Price,
            int IdTransportInCountry,
            int CustomsPayment,
            int VolumeQuota,
            SqlConnection connection
        ) {
            var command = new SqlCommand("sp_AddCusDeclar", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var typeDecParam = new SqlParameter {
                ParameterName = "@TypeDec",
                Value = TypeDec
            };

            var numbSupplyParam = new SqlParameter {
                ParameterName = "@NumbSupply",
                Value = NumbSupply
            };

            var quantityProdParam = new SqlParameter {
                ParameterName = "@QuantityProd",
                Value = QuantityProd
            };

            var idTransOutCountryParam = new SqlParameter {
                ParameterName = "@IdTransportOutCountry",
                Value = IdTransportOutCountry
            };

            var priceParam = new SqlParameter {
                ParameterName = "@Price",
                Value = Price
            };

            var idTransInCountryParam = new SqlParameter {
                ParameterName = "@IdTransportInCountry",
                Value = IdTransportInCountry
            };

            var customsPaymentParam = new SqlParameter {
                ParameterName = "@CustomsPayment",
                Value = CustomsPayment
            };

            var volumeQuotaParam = new SqlParameter {
                ParameterName = "@VolumeQuota",
                Value = VolumeQuota
            };

            command.Parameters.Add(typeDecParam);
            command.Parameters.Add(numbSupplyParam);
            command.Parameters.Add(quantityProdParam);
            command.Parameters.Add(idTransOutCountryParam);
            command.Parameters.Add(priceParam);
            command.Parameters.Add(idTransInCountryParam);
            command.Parameters.Add(customsPaymentParam);
            command.Parameters.Add(volumeQuotaParam);

            try {
                command.ExecuteNonQuery();
                return null;
            }
            catch (SqlException ex) {
                return "Ошибка при добавлении декларации";
            }
        }

        public static string AddSupply(
            int IdNumbSup,
            int IdNumbCus,
            int CodeCNFEA,
            int WeightSup,
            SqlConnection connection
        )
        {
            var command = new SqlCommand("sp_AddSupply", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            var supParam = new SqlParameter
            {
                ParameterName = "@IdNumbSup",
                Value = IdNumbSup
            };

            var cusParam = new SqlParameter
            {
                ParameterName = "@IdNumbCus",
                Value = IdNumbCus
            };

            var cnfeaParam = new SqlParameter
            {
                ParameterName = "@CodeCNFEA",
                Value = CodeCNFEA
            };

            var weightParam = new SqlParameter
            {
                ParameterName = "@WeightSup",
                Value = WeightSup
            };

            command.Parameters.Add(supParam);
            command.Parameters.Add(cusParam);
            command.Parameters.Add(cnfeaParam);
            command.Parameters.Add(weightParam);

            try
            {
                command.ExecuteNonQuery();
                return null;
            }
            catch (SqlException ex)
            {
                return "Ошибка при добавлении поставки";
            }
        }
        public static int NotAddSupply(
            int numbSupply,
            SqlConnection connection
        ) {
            var command = new SqlCommand("NotAddSupply", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var numbSupParam = new SqlParameter {
                ParameterName = "@NumbSupply",
                Value = numbSupply
            };

            var countParam = new SqlParameter {
                ParameterName = "@Count",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            command.Parameters.Add(numbSupParam);
            command.Parameters.Add(countParam);

            try {
                command.ExecuteNonQuery();
                return Convert.ToInt32(command.Parameters["@Count"].Value.ToString());
            }
            catch (SqlException ex) {
                return -1;
            }
        }
        public static int GetCountEmployee(
            int idNumbEmployee,
            SqlConnection connection
        ) {
            var command = new SqlCommand("GetCountEmployee", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var idParam = new SqlParameter {
                ParameterName = "@IdNumbEmployee",
                Value = idNumbEmployee
            };

            var countParam = new SqlParameter {
                ParameterName = "@Count",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            command.Parameters.Add(idParam);
            command.Parameters.Add(countParam);

            try {
                command.ExecuteNonQuery();
                return Convert.ToInt32(command.Parameters["@Count"].Value.ToString());
            }
            catch (SqlException ex) {
                return -1;
            }
        }

        public static int AddEmployee(
            int code,
            string name,
            string surname,
            string patron,
            SqlConnection connection
        ) {
            var command = new SqlCommand("sp_AddEmployee", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var codeParam = new SqlParameter {
                ParameterName = "@CodeCustoms",
                Value = code
            };

            var nameParam = new SqlParameter {
                ParameterName = "@NameE",
                Value = name
            };

            var surnameParam = new SqlParameter {
                ParameterName = "@SurnameE",
                Value = surname
            };

            var patronParam = new SqlParameter {
                ParameterName = "@PatronymicE",
                Value = patron
            };

            command.Parameters.Add(codeParam);
            command.Parameters.Add(nameParam);
            command.Parameters.Add(surnameParam);
            command.Parameters.Add(patronParam);

            try {
                command.ExecuteNonQuery();

                command = new SqlCommand("select ident_current('Employee')", connection);
                return int.Parse(command.ExecuteScalar().ToString());
            }
            catch (SqlException ex) {
                return -1;
            }
        }

        public static string DeleteCustDec(int custDecID, SqlConnection connection) {
            var command = new SqlCommand("sp_DeleteCustDec", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var id = new SqlParameter{
                ParameterName = "@NumbCusDec",
                Value = custDecID
            };

            command.Parameters.Add(id);

            try {
                command.ExecuteNonQuery();
                return null;
            }
            catch (SqlException ex) {
                return "Ошибка при удалении таможенной декларации";
            }
        }

        public static string DeleteSupply(int supID, SqlConnection connection) {
            var command = new SqlCommand("sp_DeleteSupply", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var id = new SqlParameter {
                ParameterName = "@NumbSupply",
                Value = supID
            };

            command.Parameters.Add(id);

            try {
                command.ExecuteNonQuery();
                return null;
            } catch (SqlException ex) {
                return "Ошибка при удалении поставки";
            }
        }
        
        public static string UpdateSupplier(
            int id,
            string fio,
            string phone,
            string address,
            string email,
            SqlConnection connection
        ) {
            var command = new SqlCommand("sp_UpdateSupplier", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var supId = new SqlParameter {
                ParameterName = "@SupIdCompany",
                Value = id
            };

            var fioParam = new SqlParameter {
                ParameterName = "@SupFIO",
                Value = fio
            };

            var phoneParam = new SqlParameter {
                ParameterName = "@SupTelNumber",
                Value = phone
            };

            var addressParam = new SqlParameter {
                ParameterName = "@SupAdress",
                Value = address
            };

            var emailParam = new SqlParameter {
                ParameterName = "@SupEmail",
                Value = email
            };

            command.Parameters.Add(supId);
            command.Parameters.Add(fioParam);
            command.Parameters.Add(phoneParam);
            command.Parameters.Add(addressParam);
            command.Parameters.Add(emailParam);

            try {
                command.ExecuteNonQuery();
                return null;
            }
            catch (SqlException ex) {
                return "Ошибка при обновлении поставщика";
            }
        }

        public static string UpdateCustomer(
            int id,
            string fio,
            string phone,
            string address,
            string email,
            SqlConnection connection
        ) {
            var command = new SqlCommand("sp_UpdateCustomer", connection) {
                CommandType = CommandType.StoredProcedure
            };

            var cusID = new SqlParameter {
                ParameterName = "@CusIdCompany",
                Value = id
            };

            var fioParam = new SqlParameter {
                ParameterName = "@CusFIO",
                Value = fio
            };

            var phoneParam = new SqlParameter {
                ParameterName = "@CusTelNumber",
                Value = phone
            };

            var addressParam = new SqlParameter {
                ParameterName = "@CusAddress",
                Value = address
            };

            var emailParam = new SqlParameter {
                ParameterName = "@CusEmail",
                Value = email
            };

            command.Parameters.Add(cusID);
            command.Parameters.Add(fioParam);
            command.Parameters.Add(phoneParam);
            command.Parameters.Add(addressParam);
            command.Parameters.Add(emailParam);

            try {
                command.ExecuteNonQuery();
                return null;
            }
            catch (SqlException ex) {
                return "Ошибка при обновлении заказчика";
            }
        }
    }
}
