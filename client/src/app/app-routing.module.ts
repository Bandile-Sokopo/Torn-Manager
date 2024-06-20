import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { FactionsComponent } from './factions/factions.component';
import { NpcLootComponent } from './npc-loot/npc-loot.component';
import { StocksComponent } from './stocks/stocks.component';
import { authGuard } from './_guards/auth.guard';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'factions', component: FactionsComponent, canActivate: [authGuard] },
  { path: 'npc-loot', component: NpcLootComponent },
  { path: 'stocks', component: StocksComponent },
  { path: '**', component: HomeComponent, pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
