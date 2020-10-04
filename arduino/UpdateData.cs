#include <WiFi.h>
#include <Bridge.h>
#include <HttpClient.h>

void setup() {
  pinMode(13, OUTPUT);
  WiFi.begin(REDACTED, REDACTED);
   while(WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  digitalWrite(13, LOW);
  Bridge.begin();
  Serial.begin(115200);
}

void loop(){
  String server = http://754da86a5cac.ngrok.io/update;
  String server_request = server + "?" + water_data;
  client.post(server_request);
  
   if(WiFi.status() == WL_CONNECTED){
      client.begin(server.c_str());
      int status = client.GET();
      if(status > 0){
        client.POST(server_request)
      }
   }
   
   # update every 10 secs
   delay(10000)
}
