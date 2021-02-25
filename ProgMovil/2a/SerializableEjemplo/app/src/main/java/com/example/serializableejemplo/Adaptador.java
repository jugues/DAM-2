package com.example.serializableejemplo;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;

public class Adaptador extends BaseAdapter {

    private Context contexto;
    private ArrayList<Elemento> miLista;

    public Adaptador(Context contexto, ArrayList<Elemento> miLista) {
        this.contexto = contexto;
        this.miLista = miLista;
    }

    @Override
    public int getCount() {
        return miLista.size();
    }

    @Override
    public Object getItem(int position) {
        return miLista.get(position);
    }

    @Override
    public long getItemId(int position) { //no desarrollado
        return 0;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        Elemento item = (Elemento)getItem(position);

        convertView = LayoutInflater.from(contexto).inflate(R.layout.item, null);
        ImageView imgv = (ImageView)convertView.findViewById(R.id.imgvFoto);
        TextView tvTitulo = (TextView)convertView.findViewById(R.id.tvTitulo);
        TextView tvContenido = (TextView)convertView.findViewById(R.id.tvTitulo);

        imgv.setImageResource(item.getImgvFoto());
        tvTitulo.setText(item.getTitulo());
        tvContenido.setText(item.getContenido());
        return convertView;
    }
}
