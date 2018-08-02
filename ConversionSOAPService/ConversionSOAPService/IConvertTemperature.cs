using System.Runtime.Serialization;
using System.ServiceModel;// Namespace to create a service

namespace ConversionSOAPService
{
   /// <summary>
   /// This service convert degree celcius to Fahrenit 
   /// </summary>
    [ServiceContract]
    public interface IConvertTemperature
    {
        // TODO: Add your service operations here
        [OperationContract]
        string CelciusToFahrenheit(decimal celcius);

        [OperationContract]
        string FahrenheitToCelcius(decimal Fahrenheit);
    }
}
