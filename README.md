# Coffee Shop App

A small C# console app (.NET Framework 4.7.2) for ordering a drink and printing the bill. Built to practise object-oriented design.

## How it works

- `Drink` is an **abstract class** with protected `name` and `price` fields, read-only `Name`/`Price` properties and an abstract `Prepare()` method.
- `Coffee` and `Tea` **inherit** from `Drink`, set their own name and price, and **override** `Prepare()` (polymorphism).
- `Order` holds a drink and a quantity, calculates the total (`CalculateBill()`) and prints the bill.
- `Program` reads the user's choice and quantity from the console.

## Run

Open `CoffeeShopApp.csproj` in Visual Studio and press F5.

## Next steps

- Validate input with `int.TryParse` instead of `int.Parse`
- Use `decimal` instead of `double` for prices
- Support several drinks per order
