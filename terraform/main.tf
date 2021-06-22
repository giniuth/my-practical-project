variable services {
    default = {
        "NumbersGU" = "NumbersGU-app-service"
        "LettersGU" = "LettersGU-app-service"
        "MergeGU"= "MergeGU-app-service"
        "FrontEndGU"= "GiniFrontEnd-app-service"
    }
}
provider "azurerm" { 
    features {} 
    }

resource "azurerm_resource_group" "rg" {
  name     = "ginis-resources"
  location = "uksouth"
}

resource "azurerm_app_service_plan" "master" {
  name                = "ginis-appserviceplan"
  location            = azurerm_resource_group.rg.location
  kind                = "Windows"
  reserved            = false

  resource_group_name = azurerm_resource_group.rg.name
  sku {
    tier = "Basic"
    size = "B1"
  }
}

resource "azurerm_app_service" "master" {

    for_each = var.services
    name = each.value
    location = azurerm_resource_group.rg.location
    resource_group_name = azurerm_resource_group.rg.name
    app_service_plan_id = azurerm_app_service_plan.master.id

    site_config{
        dotnet_framework_version ="v5.0"
    }

    app_settings = {
     "AppSettings__numbersServiceURL": "https://NumbersGU-app-service.azurewebsites.net/"
     "AppSettings__lettersServiceURL": "https://LettersGU-app-service.azurewebsites.net/"
     "AppSettings__mergedServiceURL" : "https://MergeGU-app-service.azurewebsites.net/"
    }
}
