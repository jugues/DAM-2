package com.example.sonidoanimales;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.GridLayout;
import android.widget.ImageView;

public class Adaptador extends BaseAdapter {

    private Context c;
    private Integer[] misImagenes = {R.drawable.perro, R.drawable.gato, R.drawable.lobo, R.drawable.oso, R.drawable.elefante};

    public Adaptador(Context c)
    {
        this.c = c;
    }

    @Override
    public int getCount() {
        return misImagenes.length;
    }

    @Override
    public Object getItem(int position) {
        return null;
    }

    @Override
    public long getItemId(int position) {
        return 0;
    }

    public int getImagenesId(int position)
    {
        return misImagenes[position];
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        ImageView imv = null;

        if(convertView == null)
        {
            imv = new ImageView(c);
            imv.setLayoutParams(new GridLayout.LayoutParams());
            imv.setScaleType(ImageView.ScaleType.CENTER_CROP);
        }

        else
        {
            imv = (ImageView) convertView;
        }

        imv.setImageResource(misImagenes[position]);
        return imv;
    }
}
