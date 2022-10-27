# castanedaPRestaurantPickerEndpoint

Created an endpoint which calls a function that randomly picks a restaurant from a food category the user chooses.

User will input a category of food (european, american, asian, latin) and a random restaurant based on the category they chose will be recommended to them. The output will be seen in the postman console.


To run this program you must open Postman app. Then from IDE you use to open code file run the Debug. Once you run it get the localhost server information and copy and paste it the the url box in Postman. Add the name of the Controller minus the "Controller" portion of the file name. Then add the route name. Use this format (localhost/7126/controllernamehere/routenamehere). You will need to write a JSON format code in Postman under body/raw/JSON once in the JSON file input the JSON format code like this {"variablename" : "your input here"}. The "variablename" can be found under Models folder in IDE. After you finish inputing the JSON code click "send" next to the url box in Postman. You will then see the result in the Postman console.
