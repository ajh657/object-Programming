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

        [OperationContract]
        Car GetCar(Car car);

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
        private string AutonMalli;

        private int VaritID;
        private string Vari;

        private int PolttoaineID;
        private string Polttoaine;

        [DataMember]
        public int type { get {
                if (Type == 1)
                {

                }
                return Type;

            } set { Type = value; } }
        [DataMember]
        public int id { get => ID; set => ID = value; }
        [DataMember]
        public decimal hinta { get {
                decimal hintaData = 0;

                if (Type == 0)
                {
                    SQL sql = new SQL();
                    hintaData = sql.SelectHintaData(ID);

                    return hintaData;
                }
                else
                {
                    return Hinta;
                }
            } set => Hinta = value; }
        [DataMember]
        public string date { get {
                string dateData;
                if (Type == 0)
                {
                    SQL sql = new SQL();

                    dateData = sql.SelectDateData(ID);

                    return dateData;
                }
                else
                {
                    return Date;
                }
            } set => Date = value; }
        [DataMember]
        public decimal moottorin_tilavuus { get
            {
                decimal MTData = 0;

                if (Type == 0)
                {
                    SQL sql = new SQL();
                    MTData = sql.SelectMTData(ID);

                    return MTData;
                }
                else
                {
                    return Moottorin_tilavuus;
                }
            } set => Moottorin_tilavuus = value; }
        [DataMember]
        public int mittarilukema
        {
            get
            {
                int ML = 0;

                if (Type == 0)
                {
                    SQL sql = new SQL();
                    ML = sql.SelectMLData(ID);

                    return ML;
                }
                else
                {
                    return ML;
                }
            } set => MittariLukema = value; }
        [DataMember]
        public int autonmerkkiId { get => AutonMerkkiID; set => AutonMerkkiID = value; }
        [DataMember]
        public string autonmerkki { get
            {
                string AMData;
                if (Type == 0)
                {
                    SQL sql = new SQL();

                    AMData = sql.SelectAMData(ID);

                    return AMData;
                }
                else
                {
                    return AutonMerkki;
                }
            } set => AutonMerkki = value; }
        [DataMember]
        public int automalliId { get => AutoMalliID; set => AutoMalliID = value; }
        [DataMember]
        public string autonmalli {
            get
            {
                string AUMData;
                if (Type == 0)
                {
                    SQL sql = new SQL();

                    AUMData = sql.SelectAUMData(ID);

                    return AUMData;
                }
                else
                {
                    return AutonMalli;
                }
            } set => AutonMalli = value; }
        [DataMember]
        public int varitId { get => VaritID; set => VaritID = value; }
        [DataMember]
        public string vari {
            get
            {
                string VData;
                if (Type == 0)
                {
                    SQL sql = new SQL();

                    VData = sql.SelectVData(ID);

                    return VData;
                }
                else
                {
                    return Vari;
                }
            }
            set => Vari = value; }
        [DataMember]
        public int polttoaineId { get => PolttoaineID; set => PolttoaineID = value; }
        [DataMember]
        public string polttoaine {
            get
            {
                string PData;
                if (Type == 0)
                {
                    SQL sql = new SQL();

                    PData = sql.SelectPData(ID);

                    return PData;
                }
                else
                {
                    return Polttoaine;
                }
            }
            set => Polttoaine = value; }
    }
}
