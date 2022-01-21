using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceSayur
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string pesanan(string id_pesanan, string id_sayur, string id_pembayaran, int jumlah);

        [OperationContract]
        string editpesanan(string id_pesanan, string id_sayur, string id_pembayaran, int jumlah);

        [OperationContract]
        string deletepesanan(string id_pesanan, string id_sayur, string id_pembayaran, int jumlah);

        [OperationContract]
        List<CekSayur> ReviewSayur();

        [OperationContract]
        List<CekPembayaran> ReviewPembayaran();

        [OperationContract]
        List<Pesanan> Pesanan();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceSayur.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class CekSayur
    {
        [DataMember]
        public string id_sayur { get; set; }
        [DataMember]
        public string nama_sayur { get; set; }
        [DataMember]
        public string harga_sayur { get; set; }
    }

    [DataContract]
    public class CekPembayaran
    {
        [DataMember]
        public string id_pembayaran { get; set; }
        [DataMember]
        public string tanggal_bayar { get; set; }
        [DataMember]
        public string total_bayar { get; set; }
        [DataMember]
        public string id_pembeli { get; set; }

    }

    [DataContract]
    public class Pesanan
    {

    }

}