alter proc get_all_customers
as
select 
[Customer_ID]
      ,[Customer_Name] as 'الاسم الشخصي'
      ,[Customer_LastName] as 'اللقب'
      ,[Customer_Mobile] as 'الهاتف'
      ,[Customer_Address] as 'الإيميل'
	  ,Customer_Photo
  FROM [Customers]

