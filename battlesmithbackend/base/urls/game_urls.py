from django.urls import path
from base.views import game_views as views

urlpatterns = [
    path('create/', views.addGame, name="game-create"),
    path('', views.getAllGames, name="games"),
]
