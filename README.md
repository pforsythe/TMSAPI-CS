#Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (TMSAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=TMSAPI-CSharp&workspaceName=TMSAPI&projectName=TMSAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the TMSAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=TMSAPI-CSharp&workspaceName=TMSAPI&projectName=TMSAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=TMSAPI-CSharp&workspaceName=TMSAPI&projectName=TMSAPI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=TMSAPI-CSharp&workspaceName=TMSAPI&projectName=TMSAPI.PCL)

### 3. Add reference of the library project

In order to use the TMSAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=TMSAPI-CSharp&workspaceName=TMSAPI&projectName=TMSAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` TMSAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```TMSAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=TMSAPI-CSharp&workspaceName=TMSAPI&projectName=TMSAPI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=TMSAPI-CSharp&workspaceName=TMSAPI&projectName=TMSAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

TMSAPIClient client = new TMSAPIClient(basicAuthUserName, basicAuthPassword);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [OtherController](#other_controller)
* [ShipmentController](#shipment_controller)
* [QuoteController](#quote_controller)
* [OrderController](#order_controller)
* [TrackingController](#tracking_controller)

### <a name="other_controller"></a>![Class: ](http://apidocs.io/img/class.png "TMSAPI.PCL.Controllers.OtherController") OtherController

#### Get singleton instance

The singleton instance of the ``` OtherController ``` class can be accessed from the API Client.

```csharp
OtherController other = client.Other;
```

#### <a name="get_accessorials"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OtherController.GetAccessorials") GetAccessorials

> Get list of all available accessorials


```csharp
Task<AccItems> GetAccessorials()
```

#### Example Usage

```csharp

AccItems result = await other.GetAccessorials();

```


#### <a name="get_accessorial_by_id"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OtherController.GetAccessorialByID") GetAccessorialByID

> Get a Single Accessorial By Id


```csharp
Task<AccItem> GetAccessorialByID(int aCCCHARGEID)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| aCCCHARGEID |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int aCCCHARGEID = 232;

AccItem result = await other.GetAccessorialByID(aCCCHARGEID);

```


#### <a name="get_references"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OtherController.GetReferences") GetReferences

> Get the list of Reference Types


```csharp
Task<ShipmentReferences> GetReferences()
```

#### Example Usage

```csharp

ShipmentReferences result = await other.GetReferences();

```


#### <a name="get_references_by_id"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OtherController.GetReferencesById") GetReferencesById

> Get single reference by id


```csharp
Task<ShipmentReference> GetReferencesById(int referenceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| referenceId |  ``` Required ```  | Reference Id of Reference to get details for |


#### Example Usage

```csharp
int referenceId = 232;

ShipmentReference result = await other.GetReferencesById(referenceId);

```


#### <a name="get_container_types"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OtherController.GetContainerTypes") GetContainerTypes

> Get collection of Container Types


```csharp
Task<List<Container>> GetContainerTypes()
```

#### Example Usage

```csharp

List<Container> result = await other.GetContainerTypes();

```


#### <a name="get_container_type_by_id"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OtherController.GetContainerTypeById") GetContainerTypeById

> Get a single container type by its Id


```csharp
Task<Container> GetContainerTypeById(string containerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| containerId |  ``` Required ```  | Container Id for container type requested |


#### Example Usage

```csharp
string containerId = "ContainerId";

Container result = await other.GetContainerTypeById(containerId);

```


#### <a name="get_hazmat"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OtherController.GetHazmat") GetHazmat

> Get Hazmat details


```csharp
Task<List<Hazmat>> GetHazmat()
```

#### Example Usage

```csharp

List<Hazmat> result = await other.GetHazmat();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="shipment_controller"></a>![Class: ](http://apidocs.io/img/class.png "TMSAPI.PCL.Controllers.ShipmentController") ShipmentController

#### Get singleton instance

The singleton instance of the ``` ShipmentController ``` class can be accessed from the API Client.

```csharp
ShipmentController shipment = client.Shipment;
```

#### <a name="get_shipment_details"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.ShipmentController.GetShipmentDetails") GetShipmentDetails

> Get Details of Shipment


```csharp
Task<Shipment> GetShipmentDetails(string shipmentId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shipmentId |  ``` Required ```  | Shipment Id to pull shipment info |


#### Example Usage

```csharp
string shipmentId = "ShipmentId";

Shipment result = await shipment.GetShipmentDetails(shipmentId);

```


#### <a name="add_shipment"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.ShipmentController.AddShipment") AddShipment

> Add a Shipment to system


```csharp
Task<Shipment> AddShipment(Shipment shipment)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shipment |  ``` Required ```  | Shipment Object to book |


#### Example Usage

```csharp
var shipment = new Shipment();

Shipment result = await shipment.AddShipment(shipment);

```


#### <a name="delete_cancel_shipment"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.ShipmentController.DeleteCancelShipment") DeleteCancelShipment

> TODO: Add a method description


```csharp
Task<bool> DeleteCancelShipment(string shipmentId, string userId, string reason = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shipmentId |  ``` Required ```  | Shipment Id to Cancel |
| userId |  ``` Required ```  | User requesting cancelation |
| reason |  ``` Optional ```  | Reason for canceling Shipment |


#### Example Usage

```csharp
string shipmentId = "ShipmentId";
string userId = "UserId";
string reason = "Reason";

bool result = await shipment.DeleteCancelShipment(shipmentId, userId, reason);

```


#### <a name="update_shipment"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.ShipmentController.UpdateShipment") UpdateShipment

> Update Existing Shipment


```csharp
Task<Shipment> UpdateShipment(Shipment shipment)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shipment |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var shipment = new Shipment();

Shipment result = await shipment.UpdateShipment(shipment);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="quote_controller"></a>![Class: ](http://apidocs.io/img/class.png "TMSAPI.PCL.Controllers.QuoteController") QuoteController

#### Get singleton instance

The singleton instance of the ``` QuoteController ``` class can be accessed from the API Client.

```csharp
QuoteController quote = client.Quote;
```

#### <a name="create_get_quote"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.QuoteController.CreateGetQuote") CreateGetQuote

> Get a list of rates back


```csharp
Task<Quote> CreateGetQuote(Quote quote)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| quote |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var quote = new Quote();

Quote result = await quote.CreateGetQuote(quote);

```


#### <a name="get_quote_details"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.QuoteController.GetQuoteDetails") GetQuoteDetails

> Get Details of a Quote


```csharp
Task<Quote> GetQuoteDetails(string quoteId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| quoteId |  ``` Required ```  | Quote Id for quote you want details for |


#### Example Usage

```csharp
string quoteId = "QuoteId";

Quote result = await quote.GetQuoteDetails(quoteId);

```


#### <a name="get_quote_group"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.QuoteController.GetQuoteGroup") GetQuoteGroup

> Get All Quotes in a Group


```csharp
Task<Quote> GetQuoteGroup(int quoteGroupId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| quoteGroupId |  ``` Required ```  | Quote Group Id of Quotes you want details for |


#### Example Usage

```csharp
int quoteGroupId = 232;

Quote result = await quote.GetQuoteGroup(quoteGroupId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="order_controller"></a>![Class: ](http://apidocs.io/img/class.png "TMSAPI.PCL.Controllers.OrderController") OrderController

#### Get singleton instance

The singleton instance of the ``` OrderController ``` class can be accessed from the API Client.

```csharp
OrderController order = client.Order;
```

#### <a name="add_order"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OrderController.AddOrder") AddOrder

> Add new Pending Order


```csharp
Task<Order> AddOrder(Order order)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| order |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var order = new Order();

Order result = await order.AddOrder(order);

```


#### <a name="get_order_details"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OrderController.GetOrderDetails") GetOrderDetails

> Get Details of Order


```csharp
Task<Order> GetOrderDetails(int orderUID)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderUID |  ``` Required ```  | Uid of Order to get details on |


#### Example Usage

```csharp
int orderUID = 232;

Order result = await order.GetOrderDetails(orderUID);

```


#### <a name="delete_order"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OrderController.DeleteOrder") DeleteOrder

> Delete a Pending Order


```csharp
Task<bool> DeleteOrder(int orderUID)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderUID |  ``` Required ```  | Order Uid to delete |


#### Example Usage

```csharp
int orderUID = 232;

bool result = await order.DeleteOrder(orderUID);

```


#### <a name="update_order"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.OrderController.UpdateOrder") UpdateOrder

> Update Existing Order


```csharp
Task<Order> UpdateOrder(Order order)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| order |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var order = new Order();

Order result = await order.UpdateOrder(order);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="tracking_controller"></a>![Class: ](http://apidocs.io/img/class.png "TMSAPI.PCL.Controllers.TrackingController") TrackingController

#### Get singleton instance

The singleton instance of the ``` TrackingController ``` class can be accessed from the API Client.

```csharp
TrackingController tracking = client.Tracking;
```

#### <a name="get_shipment_status"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.TrackingController.GetShipmentStatus") GetShipmentStatus

> Get status of shipment


```csharp
Task<Tracking> GetShipmentStatus(string referenceNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| referenceNumber |  ``` Required ```  | Shipment Id or Pro Number to look up shipment |


#### Example Usage

```csharp
string referenceNumber = "ReferenceNumber";

Tracking result = await tracking.GetShipmentStatus(referenceNumber);

```


#### <a name="create_get_status_of_multiple_shipments"></a>![Method: ](http://apidocs.io/img/method.png "TMSAPI.PCL.Controllers.TrackingController.CreateGetStatusOfMultipleShipments") CreateGetStatusOfMultipleShipments

> Get status of multiple shipments at once


```csharp
Task<List<Tracking>> CreateGetStatusOfMultipleShipments(List<string> trackingNumbers)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| trackingNumbers |  ``` Required ```  ``` Collection ```  | Shipment Ids or Reference Numbers of Shipments to track |


#### Example Usage

```csharp
List<string> trackingNumbers = new List<string> { "TrackingNumbers" };

List<Tracking> result = await tracking.CreateGetStatusOfMultipleShipments(trackingNumbers);

```


[Back to List of Controllers](#list_of_controllers)



