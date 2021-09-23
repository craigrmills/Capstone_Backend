from django.shortcuts import render
from rest_framework.decorators import api_view, permission_classes
from rest_framework.permissions import IsAuthenticated, IsAdminUser
from rest_framework.response import Response

from base.models import Game
from base.serializers import UserSerializer, UserSerializerWithToken, GameSerializer

from rest_framework_simplejwt.serializers import TokenObtainPairSerializer
from rest_framework_simplejwt.views import TokenObtainPairView

from rest_framework import status


@api_view(['POST'])
@permission_classes([IsAdminUser])
def addGame(request):
    data = request.data

    try:
        game = Game.objects.create(
            player1=data['player1'],
            player2=data['player2'],
            p1Faction=data['p1Faction'],
            p2Faction=data['p2Faction'],
            p1Score=data['p1Score'],
            p2Score=data['p2Score'],
            loser=data['loser'],
            winner=data['winner']
        )
        serializer = GameSerializer(game, many=False)
        return Response(serializer.data)
    except:
        message = {'detail': 'Game was not created'}
        return Response(message, status=status.HTTP_400_BAD_REQUEST)


@api_view(['GET'])
def getAllGames(request):
    games = Game.objects.all()
    serializer = GameSerializer(games, many=True)
    return Response(serializer.data)
