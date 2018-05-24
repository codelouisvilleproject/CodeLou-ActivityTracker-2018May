import { Component } from '@angular/core';

@Component({
  selector: 'app-add-activity-catagories-menu',
  templateUrl: './add-activity-catagories-menu.component.html',
})
export class AddActivityCatagoriesMenuComponent {
  options = [
    {name: 'Endurance'},
    {name: 'Strength'},
    {name: 'Balance'},
    {name: 'Flexibility'}
   ];
}


