from django.urls import path
from base.views import faction_views as views

urlpatterns = [
    path('', views.getAllFactions, name="all-factions"),
    path('create/', views.addFaction, name="add-faction"),
    path('<str:pk>/', views.getFactionById, name="faction-by-Id"),
]
