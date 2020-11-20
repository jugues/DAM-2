package com.example.listviewadapterpersonalizado;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;

public class Adaptador extends BaseAdapter {

    private Context miContexto;
    private ArrayList<Persona> miArr;

    public Adaptador(Context c, ArrayList<Persona> a)
    {
        miContexto = c;
        miArr = a;
    }

    @Override
    public int getCount() { //nº de elementos del listview, importante modificarlo
        return miArr.size();
    }

    @Override
    public Object getItem(int position) {
        return miArr.get(position);
    }

    @Override
    public long getItemId(int position) {
        return miArr.get(position).getCod();
    }

    @Override
    public View getView(int position, View view, ViewGroup parent) {

        LayoutInflater inf = LayoutInflater.from(miContexto);
        view = inf.inflate(R.layout.activity_item, null);
        TextView nom = (TextView) view.findViewById(R.id.tvNombre);
        TextView desc = (TextView) view.findViewById(R.id.tvDescripcion);
        ImageView imv = (ImageView) view.findViewById(R.id.imgviewFoto);

        nom.setText(miArr.get(position).getNombre());
        desc.setText(miArr.get(position).getDescripcion());
        imv.setImageResource(miArr.get(position).getFoto());

        return view;
    }
}
