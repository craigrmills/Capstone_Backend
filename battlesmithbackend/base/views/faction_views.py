from django.shortcuts import render
from rest_framework.decorators import api_view, permission_classes
from rest_framework.permissions import IsAuthenticated, IsAdminUser
from rest_framework.response import Response

from base.models import Faction
from base.serializers import UserSerializer, UserSerializerWithToken, FactionSerializer

from rest_framework_simplejwt.serializers import TokenObtainPairSerializer
from rest_framework_simplejwt.views import TokenObtainPairView

from rest_framework import status


@api_view(['GET'])
def getAllFactions(request):
    factions = Faction.objects.all()
    serializer = FactionSerializer(factions, many=True)
    return Response(serializer.data)


@api_view(['GET'])
def getFactionById(request, pk):
    factions = Faction.objects.get(_id=pk)
    serializer = FactionSerializer(factions, many=False)
    return Response(serializer.data)


@api_view(['POST'])
def addFaction(request):
    data = request.data

    try:
        faction = Faction.objects.create(
            name=data['name'],
            numPlayed=0,
            winRate=0
        )
        serializer = FactionSerializer(faction, many=False)
        return Response(serializer.data)
    except:
        message = {'detail': 'Faction was not created'}
        return Response(message, status=status.HTTP_400_BAD_REQUEST)
