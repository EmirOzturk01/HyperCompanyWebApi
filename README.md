# HyperCompanyWebApi
Bu uygulama Hyper Company şirketi Test Case çalışması olarak yapılmıştır.
# İsterler
Backend Project

Create a web API project (.NET Core)

The user should have access to a repository of cars, boats, and buses with different colors (red, blue, black, white). 

The car should be a vehicle (base class). A vehicle can have a color and buses and boats can be a vehicle. 

The car should have wheels and headlights. 

Make the below API to access:
• [GET] User should be able to select cars by color.

• [GET] User should be able to select buses by color.

• [GET] User should be able to select boats by color.

• [POST] User should be able to turn on/off headlights of the car by car’s ID.

• [DELETE] User should be able to delete the car. 

The code that selects the vehicles and returns it should be in a separate class (scoped service) and should be accessed by the controller using dependency injection. 

Use postman to make the API call to your local web API. 

# Kullanılan Teknolojiler
- ASP.NET Core 8
- MSSQL
- DTO Validation
- Generic Repository Pattern
- Entity Framework Core
- JSON Web Token (JWT)

# Database Configuration
Veritabanı olarak MSSQL kullanıldı ve bağlantı yolu olarak Visual Studio içerisindeki localhost verildi. Eğer Bilgisayarınızda MSSQL kuruluysa 'Hyper.Entitites' projesini terminalde açarak 'dotnet ef database update' komutunu girmeniz yeterli olacaktır. Tekrardan Migration eklemenize gerek yoktur. Veritabanı ve seed datalar otomatik olarak oluşturulacaktır.

# Postman Dosyası
JWT nin test edilmesi için postman klasörlemesi yaptım. Kendi Postman çalışma alanınıza yüklemek için hazırlamış olduğum klasörlemeyi aşağıdan indirebilirsiniz. İndirdiğiniz dosyayı portman üzerinden çalışma alanınızda bulunan import seçeneği üzerinden yükleyebilirsiniz.

![image](https://github.com/user-attachments/assets/048614cd-27a6-4fe4-9ab1-1e4433738273)

[HyperCompany.postman_collection.json](https://github.com/user-attachments/files/16831215/HyperCompany.postman_collection.json)

# JWT
Kimlik doğrulama için JWT kullanıldı. Postman üzerinden 'GetTokenForVisitor' veya 'GetTokenForAdmin' isteklerini göndererek accessToken alabilirsiniz. Alınan accessToken Authorization menüsünden Auth Type 'Bearer Token' seçilip ilgili alana girilmeli.

![image](https://github.com/user-attachments/assets/833c9602-5f0a-47c9-a08b-b37c8479fed2)

![image](https://github.com/user-attachments/assets/96363486-78c0-4d81-b639-f79e2cd7a597)

# İstekler
Get istekleri hem 'Visitor' hem de 'Admin' rolü tarafından yapılacak şekilde kurgulandı.

Post - Put - Delete istekleri ise sadece 'Admin' rolü tarafından yapılabilecek şekilde kurgulandı.
# Şemalar
- Boat
   ![image](https://github.com/user-attachments/assets/c0118dff-46ec-4e0c-a174-34d919551a28)
- Bus
  ![image](https://github.com/user-attachments/assets/ced664bb-5446-4dae-b20d-97020f999670)
- Car
  ![image](https://github.com/user-attachments/assets/df2f181d-b8e4-49d2-bd95-d3f98dc4e596)


# İletişim

E-Mail: ozturkemir2001@gmail.com

LinkedIn: www.linkedin.com/in/emirozturk01
