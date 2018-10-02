using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServerService
    {

        [OperationContract]
        string GetData(string value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
    public class Car
    {
        private int Type;

        private int ID;
        private decimal Hinta;
        private string Date;
        private decimal Moottorin_tilavuus;
        private int MittariLukema;

        private int AutonMerkkiID;
        private string AutonMerkki;

        private int AutoMalliID;
        private string Autonmalli;

        private int VaritID;
        private string Vari;

        private int PolttoaineID;
        private string Polttoaine;

        [DataMember]
        public int type { get { return Type; } set { Type = value; } }
        [DataMember]
        public int id { get => ID; set => ID = value; }
        [DataMember]
        public decimal hinta { get => Hinta; set => Hinta = value; }
        [DataMember]
        public string date { get => Date; set => Date = value; }
        [DataMember]
        public decimal moottorin_tilavuus { get => Moottorin_tilavuus; set => Moottorin_tilavuus = value; }
        [DataMember]
        public int mittarilukema { get => MittariLukema; set => MittariLukema = value; }
        [DataMember]
        public int AutonMerkkiID1 { get => AutonMerkkiID; set => AutonMerkkiID = value; }
        [DataMember]
        public string autonmerkki { get => AutonMerkki; set => AutonMerkki = value; }
    }
}
