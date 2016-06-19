# Pick Primary Object for Import
This is an POC to try pick a prioritized objecte if there are more than one of a kind and only one should be imported.

## The idea
So you have more than one object exported via MEF but you have an implementation who needs only one.
Or you have to decide wich object is picked depending on the deployment.

## The solution?
So i thought like this: i decorate the object with an PrimaryExportAttribute (yeah i know it should be called: PrimaryImport....).
Ok now it got a little bit magic, i created an export provider wich decides wich exportdefinition to pick if you want to create one, not many, and found more than one exportdefinition matching your importdefinition.
I don't know if this is the best solution and it feals like this can cause more troubles than it solves.
So if anyone have a better idea or any other suggestions please let me know!
