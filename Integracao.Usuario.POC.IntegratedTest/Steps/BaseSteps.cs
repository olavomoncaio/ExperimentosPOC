using BoDi;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;
using Xunit;

namespace Integracao.Usuario.POC.IntegratedTest.Steps
{
    [Binding]
    public sealed class BaseSteps
    {
        private IRestClient _restClient;
        private IRestRequest _restRequest;
        private IRestResponse _restResponse;
        private readonly IObjectContainer _objectContainer;

        public BaseSteps(IObjectContainer objectContainer) => _objectContainer = objectContainer;

        [BeforeScenario]
        public void Setup()
        {
            _restClient = new RestClient();
            _restRequest = new RestRequest();
            _restResponse = new RestResponse();
            _objectContainer.RegisterInstanceAs(_restClient);
            _objectContainer.RegisterInstanceAs(_restRequest);
            _objectContainer.RegisterInstanceAs(_restResponse);
        }

        [Given(@"que o host é '(.*)'")]
        public void InserirHost(string uri) => _restClient.BaseUrl = new Uri(uri);

        [Given(@"que o endpoint é '(.*)'")]
        public void DadoQueAUrlDoEndpointEh(string endpoint)
        {
            _restRequest.Resource = endpoint;
        }

        [Given(@"o método http é '(.*)'")]
        public void DadoOMetodoHttpEh(string metodo)
        {
            if (metodo == "GET")
                _restRequest.Method = Method.GET;
            else if (metodo == "PUT")
                _restRequest.Method = Method.PUT;
            else if (metodo == "POST")
                _restRequest.Method = Method.PUT;
            else if (metodo == "DELETE")
                _restRequest.Method = Method.PUT;
        }

        [When(@"executar a requisição")]
        public void QuandoExecutarARequisicao()
        {
            if (_restRequest.Method == Method.GET)
            {             
                ExecutarRequisicao(_restRequest);
            }
        }

        [Then(@"A resposta será (.*)")]
        public void ARespostaSera(HttpStatusCode codigoDeResposta) => Assert.Equal(codigoDeResposta, _restResponse.StatusCode);

        private void ExecutarRequisicao<T>(T requestBody)
        {
            if (_restRequest.Method != Method.GET)
            {
                _restRequest.AddHeader("Content-Type", "application/json");
                _restRequest.RequestFormat = DataFormat.Json;
                _restRequest.AddJsonBody(requestBody);
            }

            _restResponse = _restClient.Execute(_restRequest);
        }
    }
}
