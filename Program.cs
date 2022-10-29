using System;
using System.Threading.Tasks;

namespace CalculatorAplication
{
    class Program
    {
        static async Task Main(string[] args)
        {

            // CalculatorSOAP
            var calculator = new CalculatorReferences.CalculatorSoapClient(CalculatorReferences.CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);

            //Chamadas
            var respostaDivisaoCalSoap = await calculator.DivideAsync(10, 5);
            var respostaSubtracaoCalSoap = await calculator.SubtractAsync(3587, 2516);
            var respostaMultiplicacaoCalSoap = await calculator.MultiplyAsync(1458, 25);
            
            
         
            // CrcindSOAP
            var cliente = new SoapDemoReferences.SOAPDemoSoapClient();

            //Chamadas
            var respostaBuscarCidadeDemoSoap = await cliente.LookupCityAsync("32809");
            var respostaMissaoDemoSoap = await cliente.MissionAsync();
            var respostaPessoaDemoSoap = await cliente.FindPersonAsync("98");



            Console.WriteLine("Resposta Chamadas Calculator SOAP");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Resultado chamada calculator.DivideAsync(10, 5): " + respostaDivisaoCalSoap.ToString());
            Console.WriteLine("Resultado chamada calculator.SubtractAsync(3587, 2516): " + respostaSubtracaoCalSoap.ToString());
            Console.WriteLine("Resultado chamada calculator.MultiplyAsync(1458, 25): " + respostaMultiplicacaoCalSoap.ToString());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("                                   ");
            Console.WriteLine("Resposta Chamadas Crcind SOAP");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Resultado chamada cliente.LookupCityAsync: " + "Cidade: "+ respostaBuscarCidadeDemoSoap.City + " - Estado: "+ respostaBuscarCidadeDemoSoap.State + " - ZipCode: "+ respostaBuscarCidadeDemoSoap.Zip);
            Console.WriteLine("Resultado chamada cliente.MissionAsync(): " + respostaMissaoDemoSoap.ToString());
            Console.WriteLine("Resultado chamada cliente.FindPersonAsync(98): " + "Nome: " + respostaPessoaDemoSoap.Name + " - Idade: " + respostaPessoaDemoSoap.Age);
            Console.WriteLine("----------------------------------");
        }

    }
}
