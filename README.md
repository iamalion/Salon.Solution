Clone project
Run command `git add .`
Run command `git commit -m "Initial commit`
In production directory, run command `touch appsettings.json`
Add the following to your new file
`{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=salon;uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
    }
}`