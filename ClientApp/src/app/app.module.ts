import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatDatepickerModule, MatNativeDateModule, MatInputModule} from '@angular/material';
import { MatFormFieldModule} from '@angular/material/form-field';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetch-data/fetch-data.component';
import { FriendsComponent } from './components/friends/friends.component';
import { AddActivityFormComponent, AddActivityCatagoriesMenuComponent, AddActivityDatepickerComponent } from './components/add-activity';


@NgModule({
  declarations: [AppComponent, NavMenuComponent, HomeComponent, FetchDataComponent, FriendsComponent,
                AddActivityCatagoriesMenuComponent, AddActivityDatepickerComponent, AddActivityFormComponent],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatInputModule,
    MatFormFieldModule,
    BrowserAnimationsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'friends', component: FriendsComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'add-activity', component: AddActivityCatagoriesMenuComponent },
      { path: 'add-activity', component: AddActivityDatepickerComponent },
      { path: 'add-activity', component: AddActivityFormComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
export class PizzaPartyAppModule {}
