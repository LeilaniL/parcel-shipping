using System;
using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        private int _height;
        private int _width;
        private int _depth;
        private int _weight;

        public Parcel(int height, int width, int depth, int weight)
        {
            _height = height;
            _width = width;
            _depth = depth;
            _weight = weight;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public void SetDepth(int depth)
        {
            _depth = depth;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetDepth()
        {
            return _depth;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public int GetVolume(int height, int width, int depth)
        {
            int volume = height * width * depth;
            return volume;
        }

        public int GetCost(int weight)
        {
            int cost = weight * 5;
            return cost;
        }


    }
}