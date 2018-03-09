# How To run 
Open the Visual Studio solution file name 'Cshpro.sln' to open this project in Visual Studio and Run the program from Visual Studio.

# About the Project
This is a very basic ecommerce shop made using C# windows forms and Visual Studio local database.

About the Project
Anyone can browse through the application to see different products but to perform any action login is needed.

It has three panels,
1. User panel
2. Staff panel
3. Admin panel

1\. User panel :
A user can easily create an account and by using that account he can buy products by 'add to cart' and 'cashout'. When a user buy's a product an order is placed and he can see the progress of his orders is the 'Transactions' window. In the 'Transactions' window there is a 'Taken' check box and there is a 'Delivered' checkbox for each order placed by the corresponding customer. Whenever a placed order is assigned to a Staff the 'Taken' checkbox will show checked and if it gets delivered the 'Delivered' checkbox will also show checked in the 'Transaction' window, hence completing a process.

2\. Staff panel :
Here Staff are the people who are deliver the orders placed by customers. A staff can not create his own staff account, it is created by the admin. A staff can only login to his account created by the admin. A staff's username follows the syntax 'S-[numbers]'. A staff can see the list of orders placed in the 'Orders' window. When he takes an order the order is then shifted from the 'Orders' window to the 'Taken' window. And when he delivers the order to the corresponding customer he is to check that order in the 'Taken' window and in doing so the order will be shifted to the corresponding staff's 'History' window, hence completing the process.

3\. Admin panel :
An admin has full control over the application. The Admin username is 'A-admin'. The basic functionalities of an Admin are create, update and delete products and also create, update and delete staff accounts.
