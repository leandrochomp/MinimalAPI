PATH_DEPLOY=../../.deploy

dockerBuild: .env env-IMAGE_NAME
	@echo "make dockerBuild"
	docker build -f Dockerfile -t ${IMAGE_NAME} .
.PHONY: dockerBuild

# To build dotnet app

shell-dotnet: .env
	docker-compose -f $(PATH_DEPLOY)/docker-compose.yml run --rm microsoft /bin/bash

dotnet-restore: .env
	@echo "make dotnet-restore"
	docker-compose -f $(PATH_DEPLOY)/docker-compose.yml run --rm microsoft dotnet restore "./src/MinimalAPI.sln"
.PHONY: dotnet-restore

dotnet-build: .env
	@echo "make dotnet-build"
	docker-compose -f $(PATH_DEPLOY)/docker-compose.yml run --rm microsoft dotnet build "./src/MinimalAPI/MinimalAPI.csproj" --configuration Release
.PHONY: dotnet-build

dotnet-publish: .env
	@echo "make dotnet-publish"
	docker-compose -f $(PATH_DEPLOY)/docker-compose.yml run --rm microsoft dotnet publish "./src/MinimalAPI/MinimalAPI.csproj" -c Release -o ./src/MinimalAPI/publish
.PHONY: dotnet-publish
