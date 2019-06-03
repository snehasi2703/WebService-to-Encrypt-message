# WebService-to-Encrypt-message
Encrypt using SHA and get original message by Post
I have created a Web API using asp.net MVC web application, .net framework 4.6, visual studio 2017.

I have deployed it on Azure and the link to access the same is : https://webservice20190427024720.azurewebsites.net/.

I could not figure out how to use curl. Locally, i tested my site using Fiddler and published site using https://www.codepunker.com/tools/http-requests.

I have attached a video of how Post and Get calls work for my service.(GetPostCallRecording.mp4)

Http Post -  https://webservice20190427024720.azurewebsites.net/api/message/foo 
Output :  2c26b46b68ffc68ff99b453c1d30413413422d706483bfa0f98a5e886266e7ae

Http Get -https://webservice20190427024720.azurewebsites.net/api/message/2c26b46b68ffc68ff99b453c1d30413413422d706483bfa0f98a5e886266e7ae
output : foo
