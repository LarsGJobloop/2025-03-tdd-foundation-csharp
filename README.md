# Test Driven Development

It's a bit of manual setup when you setup a new project.

Here's a recap of the commands

1. Initialize a new solution:

    ```sh
    dotnet new sln --name {SolutionName}
    ```

2. Initialize a new module:

    ```sh
    dotnet new {project-type} --output {ModuleName}
    ```

3. Add module to solution:

    ```sh
    dotnet sln add {ModuleName}
    ```

4. Add test module (using xUnit, xxx.Tests is convention):

    ```sh
    dotnet new xunit --output {ModuleName}.Tests
    ```

5. Add test module to solution:

    ```sh
    dotnet sln add {ModuleName}.Tests
    ```    

6. Ensure test module depends on module under test:

    ```sh
    dotnet add {ModuleName}.Tests reference {ModuleName}
    ```

7. Run all tests:

    ```sh
    dotnet test
    ```
