targetScope = 'subscription'


resource main 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: 'DndWebAppRG'
  location: 'centralus'
}

module appService 'modules/appservice.bicep' = {
  scope: main
  name: 'appService'
}
