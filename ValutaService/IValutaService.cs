using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ValutaService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IValutaService
    {
        [OperationContract]
        decimal exchange_DNK_to_EUR(decimal sum);

        [OperationContract]
        decimal find_exchange_rate(string iso_code);

        [OperationContract]
        List<Currency> GetAllRates();

        [OperationContract]
        decimal exchange_isofrom_to_isoto(string isofrom, string isoto, decimal amount);


        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ValutaService.ContractType".

    [DataContract]
    public class Currency
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string ISOcode { get; set; }

        [DataMember]
        public decimal ExchangeRate { get; set; }

        public Currency(string name, string isocode, decimal rate)
        {
            this.Name = name;
            this.ISOcode = isocode;
            this.ExchangeRate = rate;
        }

        public override string ToString()
        {
            return $"Name: {Name} - ISO: {ISOcode} - Exchange Rate: {ExchangeRate}";
        }
    }
}
