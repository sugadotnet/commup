using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class ProductstockVM
    {
        //PRODUCT
        private ProductVM _PRODUCT;
        public ProductVM PRODUCT { get { return this._PRODUCT; } set { this._PRODUCT = value; } }
        public void inject_PRODUCT(ProductVM poDATA = null) {
            if (poDATA == null) this._PRODUCT = new ProductVM();
            else this._PRODUCT = poDATA;
        } //End Method
        //PRODUCTS
        private List<ProductVM> _PRODUCTS;
        public List<ProductVM> PRODUCTS { get { return this._PRODUCTS; } set { this._PRODUCTS = value; } }
        public void inject_PRODUCTS(List<ProductVM> poDATA = null) {
            if (poDATA == null) this._PRODUCTS = new List<ProductVM>();
            else this._PRODUCTS = poDATA;
        } //End Method

        //PRODUCTSTOCK
        private ProductstockVM _PRODUCTSTOCK;
        public ProductstockVM PRODUCTSTOCK { get { return this._PRODUCTSTOCK; } set { this._PRODUCTSTOCK = value; } }
        public void inject_PRODUCTSTOCK(ProductstockVM poDATA = null) {
            if (poDATA == null) this._PRODUCTSTOCK = new ProductstockVM();
            else this._PRODUCTSTOCK = poDATA;
        } //End Method
        //PRODUCTSTOCKS
        private List<ProductstockVM> _PRODUCTSTOCKS;
        public List<ProductstockVM> PRODUCTSTOCKS { get { return this._PRODUCTSTOCKS; } set { this._PRODUCTSTOCKS = value; } }
        public void inject_PRODUCTSTOCKS(List<ProductstockVM> poDATA = null) {
            if (poDATA == null) this._PRODUCTSTOCKS = new List<ProductstockVM>();
            else this._PRODUCTSTOCKS = poDATA;
        } //End Method
        public void add_PRODUCTSTOCKS(ProductstockVM poDATA)
        {
            if (this._PRODUCTSTOCKS == null) this._PRODUCTSTOCKS = new List<ProductstockVM>();
            this._PRODUCTSTOCKS.Add(poDATA);
        } //End Method

        //TRNSTOCK
        private TrnstockVM _TRNSTOCK;
        public TrnstockVM TRNSTOCK { get { return this._TRNSTOCK; } set { this._TRNSTOCK = value; } }
        public void inject_TRNSTOCK(TrnstockVM poDATA = null) {
            if (poDATA == null) this._TRNSTOCK = new TrnstockVM();
            else this._TRNSTOCK = poDATA;
        } //End Method
        //TRNSTOCKS
        private List<TrnstockVM> _TRNSTOCKS;
        public List<TrnstockVM> TRNSTOCKS { get { return this._TRNSTOCKS; } set { this._TRNSTOCKS = value; } }
        public void inject_TRNSTOCKS(List<TrnstockVM> poDATA = null) {
            if (poDATA == null) this._TRNSTOCKS = new List<TrnstockVM>();
            else this._TRNSTOCKS = poDATA;
        } //End Method
        //TRNSTOCKD
        private TrnstockdVM _TRNSTOCKD;
        public TrnstockdVM TRNSTOCKD { get { return this._TRNSTOCKD; } set { this._TRNSTOCKD = value; } }
        public void inject_TRNSTOCK(TrnstockdVM poDATA = null) {
            if (poDATA == null) this._TRNSTOCKD = new TrnstockdVM();
            else this._TRNSTOCKD = poDATA;
        } //End Method
        //TRNSTOCKDS
        private List<TrnstockdVM> _TRNSTOCKDS;
        public List<TrnstockdVM> TRNSTOCKDS { get { return this._TRNSTOCKDS; } set { this._TRNSTOCKDS = value; } }
        public void inject_TRNSTOCKS(List<TrnstockdVM> poDATA = null) {
            if (poDATA == null) this._TRNSTOCKD = new TrnstockdVM();
            else this._TRNSTOCKDS = poDATA;
        } //End Method

    } //End public partial class ProductstockVM
} //End namespace APPBASE.Models
