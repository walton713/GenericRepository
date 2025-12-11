# Insert #

## Tasks To Complete ##

### Insert Basic Object ###

Create the ability to insert an object that has no foreign key relationships.

### Insert Complex Object - No Existing Child Object ###

Create the ability to insert an object that has a foreign key relationship. The related object does not exist at the time of insertion. The related object is inserted when the parent object is inserted.

### Insert Complex Object - Existing Child Object - Update Children ###

Create the ability to insert an object that has a foreign key relationship. The related object exists at the time of insertion. The related object is updated when the parent object is inserted.

### Insert Complex Object - Existing Child Object - Fail If Non Matching Children ###

Create the ability to insert an object that has a foreign key relationship. The related object exists at the time of insertion. If the related object it does not match what is being inserted then the insert fails.

### Insert Complex Object - Existing Child Object - Update Specific Children ###

Create the ability to insert an object that has a foreign key relationship. The related object exists at the time of insertion. Specified children are updated when the parent object is inserted. If non specified children do not match what is being inserted then the insert fails.

### Return Options - Id ###

Create the ability to return just the Id of the inserted object.

### Return Options - Inserted Object ###

Create the ability to return the entire inserted object.

### Return Options - Selected Fields - Basic Object ###

Create the ability to return selected fields from the inserted object. Returned fields are from the inserted object only.

### Return Options - Selected Fields - Complex Object ###

Create the ability to return selected fields from the inserted object. Returned fields can be from the inserted object and any child objects.
