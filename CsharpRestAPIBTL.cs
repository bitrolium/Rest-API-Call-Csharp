Get Secure Token :

var client = new RestClient("https://bitrolium.net/api/app/Gettoken/?ApiKey=**********");
var request = new RestRequest(Method.POST);
request.AddHeader("Cache-Control", "no-cache");
request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
IRestResponse response = client.Execute(request);


Create Account:

var client = new RestClient("https://bitrolium.net/api/app/createaccount?PassPhrase=******");
var request = new RestRequest(Method.POST);
request.AddHeader("Postman-Token", "50cf81c7-f2cb-b18c-ad3e-be730edb6161");
request.AddHeader("Cache-Control", "no-cache");
request.AddHeader("Authorization", "Bearer ***your token***");
IRestResponse response = client.Execute(request);


Get Balance:

var client = new RestClient("https://bitrolium.net/api/app/GetBalance/ ****Bitrolium Address****");
var request = new RestRequest(Method.GET);
request.AddHeader("Cache-Control", "no-cache");
request.AddHeader("Authorization", "Bearer  ***your token***");
IRestResponse response = client.Execute(request);


Create Transaction:

var client = new RestClient("https://www.bitrolium.net/api/app/CreateTransaction?recepient=**Address**&amount=0&description=&passphrase=&secondPassphrase=");
var request = new RestRequest(Method.POST);
request.AddHeader("Postman-Token", "1027bda2-b1dc-e771-b530-bfe8e0869b10");
request.AddHeader("Cache-Control", "no-cache");
request.AddHeader("Authorization", "Bearer  ***your token***");
IRestResponse response = client.Execute(request);