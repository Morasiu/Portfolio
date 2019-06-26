import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component';
import { NameComponent } from './name/name.component';
import { ProjectsComponent } from './projects/projects.component';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { GamesComponent } from './games/games.component';
import { MobileListComponent } from './mobile-list/mobile-list.component';
import { MobileComponent } from './mobile/mobile.component';
import { TimelineComponent } from './timeline/timeline.component';
import { SkillComponent } from './skill/skill.component';
import { AboutFieldComponent } from './about-field/about-field.component';
import { MobileGameComponent } from './mobile-game/mobile-game.component';
import { PCGameComponent } from './pc-game/pc-game.component';
import { GameVideoComponent } from './game-video/game-video.component';
import { WebComponent } from './web/web.component';
import { WebProjectComponent } from './web-project/web-project.component';
import { ImageService } from './services/ImageService';

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
          { path: 'web',
          component: WebComponent 
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
    redirectTo: '/about',
    pathMatch: 'full'
    },
    {path: '**', redirectTo: '/404'},
    {path: '404', component: PageNotFoundComponent},
];


@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    NameComponent,
    ProjectsComponent,
    PageNotFoundComponent,
    GamesComponent,
    MobileGameComponent,
    MobileListComponent,
    MobileComponent,
    TimelineComponent,
    SkillComponent,
    AboutFieldComponent,
    PCGameComponent,
    GameVideoComponent,
    WebComponent,
    WebProjectComponent,
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(
      routeConfig,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  providers: [
    ImageService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
