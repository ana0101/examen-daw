import { Routes } from '@angular/router';
import { ProfesorComponent } from './profesor/profesor.component';
import { MaterieComponent } from './materie/materie.component';
import { ProfesorMaterieComponent } from './profesor-materie/profesor-materie.component';

export const routes: Routes = [
    {
        path: "",
        component: ProfesorComponent
    },
    {
        path: "",
        component: MaterieComponent
    },
    {
        path: "",
        component: ProfesorMaterieComponent
    }
];
