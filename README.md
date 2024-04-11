# RetailProcurementSystem


Application can be run locally (IIS Express) or on Docker containers.

- If locally, change appSetting connection string to you local one (commented DefaultConnection)
- If on Docker, check your 'sa' account password under MS Server Studio Management, current one that is used here is "myStong_Password123#" (can change it under docker-compose.yml). SQL server on docker runs on MS SQL 2019 image.

I am using Bogus for seeding dummy data.
Unit tests (XUnit) are written for 'StoreItem' repository and controller using Moq and XUnit, other ones should be written in the same matter.

There is also JWT token in use, you can generate one calling 'Login' endpoint with username 'john' and password 'john123456' (this also can be changed in appSettings.json). After that you can call 'GET api/store-items' endpoint.

I have created a table called 'SalesRecord' where all the sale items are stored and from there we can call some statistics. I did not create a controller for this since I don't have time (work) but here we can implement various methods for running some statictics.
