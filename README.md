# SemanticRelease.Abstractions

A .NET Standard library providing abstractions and core interfaces for semantic versioning and release management.

## Overview

This library serves as the foundation for implementing semantic versioning in .NET projects. It provides the necessary abstractions and interfaces to manage release lifecycles and versioning in a standardized way.

## Features

- Semantic versioning support
- Plugin architecture for extensibility
- Release lifecycle management
- Configuration handling

## Requirements

- .NET Standard 2.1
- C# 8.0 or later

## Installation

You can install the package via NuGet:

```shell
dotnet add package SemanticRelease.Abstractions
```

## Project Structure
- ISemanticPlugin.cs - Core plugin interface for extending functionality
- LifecycleSteps.cs - Defines the steps in the release lifecycle
- ReleaseConfig.cs - Configuration handling for releases
- ReleaseContext.cs - Context management for release operations
- SemanticLifecycle - Implementation of semantic versioning lifecycle

## Development

### Building the Project

```shell
dotnet build
```

### Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.