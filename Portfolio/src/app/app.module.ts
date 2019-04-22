import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';
import { NameComponent } from './name/name.component';
import { ProjectsComponent } from './projects/projects.component';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { GamesComponent } from './games/games.component';
import { GameComponent } from './game/game.component';
import { MobileListComponent } from './mobile-list/mobile-list.component';
import { MobileComponent } from './mobile/mobile.component';
import { TimelineComponent } from './timeline/timeline.component';
import { SkillComponent } from './skill/skill.component';
import { ExperienceComponent } from './experience/experience.component';


export const routeConfig:Routes = [
    {
        path: 'projects',
        component: ProjectsComponent,
        children: [
          { path: '',
          redirectTo: 'games',
          pathMatch: 'full' // Default path
        },
          { path: 'mobile',
            component: MobileListComponent 
          }, 
          { path: 'games',
            component: GamesComponent 
          },
        ]
    },
    { path: 'timeline',
      component: TimelineComponent 
    },
    { path: 'about',
      component: AboutComponent
    },
    { path: '',
    redirectTo: '/projects',
    pathMatch: 'full'
    },
    {path: '404', component: PageNotFoundComponent},
    {path: '**', redirectTo: '/404'}
];


@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    NameComponent,
    ProjectsComponent,
    PageNotFoundComponent,
    GamesComponent,
    GameComponent,
    MobileListComponent,
    MobileComponent,
    TimelineComponent,
    SkillComponent,
    ExperienceComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(
      routeConfig,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
