package com.example.empleadosparcelable;

import android.os.Parcel;
import android.os.Parcelable;

public class Empleado implements Parcelable {

    String nombre;
    int edad;

    protected Empleado(Parcel in) {
        nombre = in.readString();
        edad = in.readInt();
    }

    public Empleado(String nom, int ed) {

        nombre = nom;
        edad = ed;
    }

    public static final Creator<Empleado> CREATOR = new Creator<Empleado>() {
        @Override
        public Empleado createFromParcel(Parcel in) {
            return new Empleado(in);
        }

        @Override
        public Empleado[] newArray(int size) {
            return new Empleado[size];
        }
    };

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    @Override
    public void writeToParcel(Parcel dest, int flags) {
        dest.writeString(nombre);
        dest.writeInt(edad);
    }

    @Override
    public int describeContents() {
        return 0;
    }



    public Empleado[] newArray(int size) {
            return new Empleado[size];
        }
    };

