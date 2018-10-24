using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Mutasi_revBL
    {
        //VENDOR
        protected VendorVM _VENDOR;
        public VendorVM VENDOR { get { return this._VENDOR; } set { this._VENDOR = value; } }
        public void inject_VENDOR(VendorVM poDATA = null)
        {
            if (poDATA == null) this._VENDOR = new VendorVM();
            else this._VENDOR = poDATA;
        } //End Method
        //STORAGE
        protected StorageVM _STORAGE;
        public StorageVM STORAGE { get { return this._STORAGE; } set { this._STORAGE = value; } }
        public void inject_STORAGE(StorageVM poDATA = null)
        {
            if (poDATA == null) this._STORAGE = new StorageVM();
            else this._STORAGE = poDATA;
        } //End Method
        //PRODUCT
        protected ProductnewVM _PRODUCTNEW;
        public ProductnewVM PRODUCTNEW { get { return this._PRODUCTNEW; } set { this._PRODUCTNEW = value; } }
        public void inject_PRODUCTNEW(ProductnewVM poDATA = null)
        {
            if (poDATA == null) this._PRODUCTNEW = new ProductnewVM();
            else this._PRODUCTNEW = poDATA;
        } //End Method
        //PRODUCT
        protected ProductVM _PRODUCT;
        public ProductVM PRODUCT { get { return this._PRODUCT; } set { this._PRODUCT = value; } }
        public void inject_PRODUCT(ProductVM poDATA = null)
        {
            if (poDATA == null) this._PRODUCT = new ProductVM();
            else this._PRODUCT = poDATA;
        } //End Method
        //PRODUCTS
        protected List<ProductVM> _PRODUCTS;
        public List<ProductVM> PRODUCTS { get { return this._PRODUCTS; } set { this._PRODUCTS = value; } }
        public void inject_PRODUCTS(List<ProductVM> poDATA = null)
        {
            if (poDATA == null) this._PRODUCTS = new List<ProductVM>();
            else this._PRODUCTS = poDATA;
        } //End Method
        //PRODUCTSTOCK
        protected ProductstockVM _PRODUCTSTOCK;
        public ProductstockVM PRODUCTSTOCK { get { return this._PRODUCTSTOCK; } set { this._PRODUCTSTOCK = value; } }
        public void inject_PRODUCTSTOCK(ProductstockVM poDATA = null)
        {
            if (poDATA == null) this._PRODUCTSTOCK = new ProductstockVM();
            else this._PRODUCTSTOCK = poDATA;
        } //End Method
        //PRODUCTSTOCKS
        protected List<ProductstockVM> _PRODUCTSTOCKS;
        public List<ProductstockVM> PRODUCTSTOCKS { get { return this._PRODUCTSTOCKS; } set { this._PRODUCTSTOCKS = value; } }
        public void inject_PRODUCTSTOCKS(List<ProductstockVM> poDATA = null)
        {
            if (poDATA == null) this._PRODUCTSTOCKS = new List<ProductstockVM>();
            else this._PRODUCTSTOCKS = poDATA;
        } //End Method
        //PRODUCTSTOCKS2
        protected List<ProductstockVM> _PRODUCTSTOCKS2;
        public List<ProductstockVM> PRODUCTSTOCKS2 { get { return this._PRODUCTSTOCKS2; } set { this._PRODUCTSTOCKS2 = value; } }
        public void inject_PRODUCTSTOCKS2(List<ProductstockVM> poDATA = null)
        {
            if (poDATA == null) this._PRODUCTSTOCKS2 = new List<ProductstockVM>();
            else this._PRODUCTSTOCKS2 = poDATA;
        } //End Method

        //TRNSTOCK
        protected TrnstockVM _TRNSTOCK;
        public TrnstockVM TRNSTOCK { get { return this._TRNSTOCK; } set { this._TRNSTOCK = value; } }
        public void inject_TRNSTOCK(TrnstockVM poDATA = null)
        {
            if (poDATA == null) this._TRNSTOCK = new TrnstockVM();
            else this._TRNSTOCK = poDATA;
        } //End Method

        //TRNSTOCKD
        protected TrnstockdVM _TRNSTOCKD;
        //TRNSTOCKDS
        protected List<TrnstockdVM> _TRNSTOCKDS;
        public List<TrnstockdVM> TRNSTOCKDS { get { return this._TRNSTOCKDS; } set { this._TRNSTOCKDS = value; } }
        public void inject_TRNSTOCKDS(List<TrnstockdVM> poDATA = null)
        {
            if (poDATA == null) this._TRNSTOCKDS = new List<TrnstockdVM>();
            else this._TRNSTOCKDS = poDATA;
        } //End Method
    } //End Method
} //End namespace APPBASE.Models
