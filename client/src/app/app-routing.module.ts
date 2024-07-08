import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { FactionsComponent } from './factions/factions.component';
import { NpcLootComponent } from './npc-loot/npc-loot.component';
import { StocksComponent } from './stocks/stocks.component';
import { authGuard } from './_guards/auth.guard';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [authGuard],
    children: [
      { path: 'factions', component: FactionsComponent},
      { path: 'npc-loot', component: NpcLootComponent },
      { path: 'stocks', component: StocksComponent },

    ]
  },
  {path: 'errors', component: TestErrorsComponent},
  { path: '**', component: HomeComponent, pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
