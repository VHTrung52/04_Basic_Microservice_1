**Markdown**
- Markdown file intend for simple document, at time of writing markdown file does not meet the requirment that i want but other file format will take time to note so for quick note and lesson i will use mark down and when i have time i will convert it to html

**Validation**  

[x] fixed

- The author implement validation behaviour and return `500 Internal Server Error` with this msg
![alt text](image.png) 
i don't think this is good, will update to return `400 Bad Request` with json msg

**Logging-Tracing**
- when working with micro-service, one of the main problem is tracing the logging between different service, like when you have a api to get user's order in which you have to get user info and order info. When debug that api you need to know if the 2 api is success or not and their input and output and also have something other than input and output to trace the api that called to user service and order service maybe traceId or requestId or sth. I think this course missing that and i will implement it in the feature.
- The data that you log also need to be reproducable which mean with the input you can reproduce that case/ that api call using postman without wasting time editing, modifing it to ascomplete this we need to serialize object using json

**Validation**
- The author implement fluent validation at command, query level and i don't think that is good, it think we should validate at request level so that when we start handle the request we know that all the data is validated 