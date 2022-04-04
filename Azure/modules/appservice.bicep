targetScope = 'resourceGroup'


resource appServicePlan 'Microsoft.Web/serverfarms@2021-03-01' = {
  name: uniqueString(resourceGroup().id)
  location: resourceGroup().location
  properties:{
    reserved: true
  }
  sku:{
    name:'F1'
  }
}

resource appService 'Microsoft.Web/sites@2021-03-01' = {
  name: 'DndWebApp-1587456'
  location: resourceGroup().location
  properties:{
    serverFarmId: appServicePlan.id
  }
}
